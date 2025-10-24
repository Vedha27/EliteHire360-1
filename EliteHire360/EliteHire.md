# Job Portal Schema with Relationships

---

**Table Name**: `User`

**Columns:**
- **userId** → `int` (PK)  
- **uniqueKey** → `guid`  
- **firstName** → `varchar(55)`  
- **lastName** → `varchar(40)`  
- **phone** → `varchar(20)` (Unique)  
- **email** → `varchar(55)` (Unique)  
- **location** → `varchar(55)`  
- **password** → `varchar(55)`  
- **createdAt** → `datetime`  
- **createdBy** → `int`  
- **lastLogin** → `datetime`  
- **deletedAt** → `datetime`  
- **deletedBy** → `int`  
- **updatedBy** → `int`  
- **updatedAt** → `datetime`  

**Relationships:**
- 1 User → 1 UserRoleMapping  
- 1 User → 1 CandidateProfile  
- 1 User → * Messages (Sender)  
- 1 User → * Messages (Receiver)  
- 1 User → * Applications 
- 1 User → * Jobs
- 1 User → * Notification  

---

**Table Name**: `UserRoleMapping`

**Columns:**
- **userRoleMappingId** → `int` (PK)  
- **userId** → `int` (FK → User.userId)  
- **roleId** → `int` (FK → Role.id)  
- **subroleId** → `int` (FK → SubRole.id)
- **createdBy** → `int`  
- **deletedBy** → `int`  
- **updatedBy** → `int`  
- **updatedAt** → `datetime`  

**Relationships:**
- 1UserRoleMapping → 1 User  
- 1UserRoleMapping → 1 Role  

---

**Table Name**: `Candidate`

**Columns:**
- **CandidateId** → `int` (PK)  
- **uniqueKey** → `guid`  
- **userId** → `int` (FK → User.userId)  
- **resumePath** → `varchar(55)`  
- **overallExperience** → `int`  
- **profile** → `jsonb`  
- **createdAt** → `datetime`  
- **createdBy** → `int`  
- **updatedAt** → `datetime`  
- **updatedBy** → `int`  
- **deletedAt** → `datetime`  

**Relationships:**
- 1 Candidate → 1 User  
- 1 Candidate → * SavedJobs  
- 1 Candidate → * Applications  
---

**Table Name**: `Job`

**Columns:**
- **id** → `int` (PK)  
- **uniqueKey** → `guid`  
- **jobTitle** → `varchar(30)`  
- **interviewProcess**  → `jsonb`
- **departmentId** → `int` (FK → Department.id)  
- **locationId** → `int` (FK → OfficeLoc.id)  
- **empType** → `int` (FK → EmploymentType.id)  
- **organisationId** → `int` (FK → Organisation.id)
- **workMode**   → `int` (FK → WorkMode.id)
- **minSalary** → `bigint`  
- **maxSalary** → `bigint`  
- **jobDesc** → `json`  
- **jobStatusId** → `int` (FK → Status.id)  
- **experienceLevelId** → `int` (FK → ExperienceLevel.expId)  
- **priorityLevel** → `int` (FK → PriorityLevel.id)  
- **jobDeadline** → `date`  
- **created_on** → `datetime`  
- **created_by** → `varchar(100)`  
- **updated_on** → `datetime`  
- **updated_by** → `varchar(100)`  

**Relationships:**
- * Job → 1 Organisation  
- 1 Job → 1 Department  
- 1 Job → 1 EmploymentType  
- 1 Job → 1 ExperienceLevel  
- 1 Job → 1 PriorityLevel  
- 1 Job → * Applications  
---

**Table Name**: `JobDraft`

**Columns:**
- **id** → `int` (PK)  
- **jobId** → `int`(FK → Job.id)
- **jobTitle** → `varchar(null)`  
- **departmentId** → `int(null)`  
- **interviewRounds**  → `jsonb`  
- **locationId** → `int(null)`  
- **empType** → `int(null)`
- **organisationId** → `int(null)` 
- **workMode**   → `int(null)` 
- **minSalary** → `bigint(null)`  
- **maxSalary** → `bigint(null)`  
- **jobDesc** → `json(null)`  
- **jobStatusId** → `int(null)` 
- **experienceLevelId** → `int(null)`
- **priorityLevel** → `int(null)` 
- **jobDeadline** → `date(null)`  
- **created_on** → `datetime(null)`  
- **created_by** → `varchar(null)`  
- **updated_on** → `datetime(null)`  
- **updated_by** → `varchar(null)`
---
**Table Name**: `Job History`

**Columns:**
- **id** → `int` (PK) 
- **jobId** → `int` (FK → Job.id)
- **jobStatusId** → `int`(Fk → Status.id)
- **createdBy** → `int` (FK →User.id)
- **CreateAt** → `datetime`
---

**Table Name**: `SavedJobs`

**Columns:**
- **id** → `int` (PK)  
- **candidateId** → `guid` (FK → Candidate.CandidateId)  
- **jobId** → `int` (FK → Job.id)  
- **isApplied** → `flag`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  
- **updatedAt** → `datetime`  
- **updatedBy** → `int`  
- **deletedAt** → `datetime`  

**Relationships:**
- *SavedJobs → 1 Candidate 
- *SavedJobs → 1 Job  
---

**Table Name**:  `Applications`

**Columns:**
- **applicationId** → `int` (PK)  
- **uniqueKey** → `guid`  
- **candidateId** → `int` (FK → Candidate.CandidateId)  
- **jobId** → `int` (FK → Job.id)  
- **screening**  → `jsonb`
- **isOfferSent** →`int`
- **isOfferAccepted** → `int`
- **personInfo** → `jsonb`
- **experience** → `jsonb`
- **resumePath** → `varchar(55)`
- **matchPercentage** → `int`
- **appliedAt** → `datetime`  
- **applicationStatusId** → `int` (FK → Status.id)  
- **createdBy** → `int` (FK → User.userId)  
- **createdAt** → `datetime`  
- **updatedAt** → `datetime`  
- **deletedAt** → `datetime`  
- **updatedBy** → `int`  

**Relationships:**
- *Applications  → 1 Job  
- 1 Applications → * ApplicationsHistory  
- 1 Applications → * ScheduledInterview  
---

**Table Name**: `ApplicationHistory`

**Columns:**
- **id** → `int` (PK)
- **uniqueKey** → `guid`  
- **applicationId** → `int` (FK → Applications.appliciationId) 
- **statusId** → `int` 
- **createdAt** → `datetime`  
- **createdBy** → `int` 
--- 

**Table Name:** `SheduledInterview`

**Columns:**
- **id** → `int` (PK)  
- **uniqueKey** → `guid`  
- **applicationId** → `int` (FK → Applications.id)  
- **parentInterviewId** →  `int`
- **interviewFormat** → `int` (FK → Interview_Format.id)  
- **interviewMode** → `varchar(20)`  
- **scheduledDate** → `datetime`  
- **startTime** → `datetime`
- **duration** → `int`  
- **status** → `varchar(40)`  
- **feedBack** → `varchar(40)`  
- **location** → `varchar(55)`  
- **createdAt** → `datetime`  
- **updatedAt** → `datetime`  
- **deletedAt** → `datetime`  
- **updatedBy** → `int`  

**Relationships:**
- *ScheduledInterview → 1 Applications  
---

**Table Name**: `ScheduledInterviewHistory`

**Columns:**
- **id** → `int` (PK) 
- **interviewId** → `int` (FK → Interview.id)
- **interviwStatusId** → `int`(Fk → Status.id)
- **createdBy** → `int` (FK →User.id)
- **CreateAt** → `datetime`
---

**Table Name**: `Organisation`

**Columns:**
- **id** → `int` (PK)  
- **uniqueKey** → `guid`  
- **uniqueKey** → `varchar(55)`  
- **name** → `varchar(55)` 
- **insudstry** → `varchar(55)`
- **overview** → `jsonb`
- **culture** → `jsonb`
- **benefit** → `varchar(55)`
- **officeLocId** → `int` (FK → OfficeLoc.id)
- **organizationStatus** → `int`
- **created_on** → `datetime`  
- **created_by** → `int` (FK → User.userId)  
- **updated_on** → `datetime`  
- **updated_by** → `int` (FK → User.userId)  
- **deleted_on** → `datetime`  
---

**Table Name**: `OrganisationTeam`

**Columns:**
- **id** → `int` (PK)  
- **uniqueKey** → `guid`  
- **firstName** → `varchar(55)`  
- **lastName** → `varchar(40)`  
- **email** → `varchar(55)` (Unique)  
- **subRoleId** → `int` (FK → SubRole.id)  
- **departmentId** → `int` (FK → Department.id)  
- **message** → `varchar(55)`  
- **created_on** → `datetime`  
- **created_by** → `int` (FK → User.userId)  
- **updated_on** → `datetime`  
- **updated_by** → `int` (FK → User.userId)  
- **deleted_on** → `datetime`  

---

**Table Name**: `OfficeLoc`

**Columns:**
- **id** → `int` (PK)  
- **uniqueKey** → `guid`  
- **OrgId** → `int` (FK → Organisation.id)  
- **name** → `varchar(50)`  
- **officeInfo** → `json`  
- **created_on** → `datetime`  
- **created_by** → `int` (FK → User.userId)  
- **updated_on** → `datetime`  
- **updated_by** → `int` (FK → User.userId)  
- **deleted_on** → `datetime` 

---
# Meta Tables
---

**Table Name:** `Role`

**Columns:**
- **id** → `int` (PK)  
- **name** → `varchar(20)`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  

---

**Table Name:** `SubRole`

**Columns:**
- **id** → `int` (PK)  
- **permission_id** → `int`  
- **role_name** → `varchar(30)`  
- **role_desc** → `varchar(256)`  
- **created_on** → `datetime`  
- **created_by** → `int`  
- **updated_on** → `datetime`  
- **updated_by** → `int`  

---

**Table Name:** `Skills`

**Columns:**
- **id** → `int` (PK)  
- **skillName** → `varchar(50)`  
- **categoryId** → `int`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  

---

**Table Name:** `SkillsCategory`

**Columns:**
- **id** → `int` (PK)  
- **categoryName** → `varchar(50)`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  

---

**Table Name:** `Industry`

**Columns:**
- **id** → `int` (PK)  
- **industryName** → `varchar(50)`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  

---

**Table Name:** `EmploymentType`

**Columns:**
- **id** → `int` (Primary Key)  
- **name** → `varchar(50)`  
- **createdBy** → `int`  
- **createdOn** → `datetime`  

---

**Table Name:** `DegreeType`

**Columns:**
- **id** → `int` (Primary Key)  
- **name** → `varchar(20)`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  

---

 **Table Name:** `DegreeStatus`

**Columns:**
- **id** → `int` (Primary Key)  
- **name** → `varchar(20)`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  

---

**Table Name:** `ProjectCategory`

**Columns:**
- **id** → `int` (Primary Key)  
- **name** → `varchar(50)`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  

---

**Table Name:** `ProjectStatus`

**Columns:**
- **id** → `int` (Primary Key)  
- **name** → `varchar(50)`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  
---

**Table Name:** `Status`

**Columns:**
- **id** → `int` (Primary Key)  
- **statusName** → `varchar(50)`  
- **statusCategory** → `int` (FK → StatusCategories.id )  
- **createdBy** → `int`  
---

**Table Name:** `StatusCategories`

**Columns:**
- **id** → `int` (Primary Key)  
- **StatusCategoryName** → `varchar(50)`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  
---
**Table Name:** `OfficeType`

**Columns:**
- **id** → `int` (Primary Key)  
- **name** → `varchar(20)`  
- **createdBy** → `int`  
- **createdAt** → `datetime`
---
**Table Name:** `Department`

**Columns:**
- **deptId** → `int` (Primary Key)  
- **deptName** → `varchar(20)`  
- **createdBy** → `int`  
- **createdAt** → `datetime`  
---
**Table Name:** `Interview_Format`

**Columns:**
- **id** → `int` (Primary Key)  
- **name** → `varchar(50)`  
- **createdOn** → `datetime`  
- **createdBy** → `int`  

---
**Table Name:** `WorkMode`

**Columns:**
- **id** → `int` (Primary Key)  
- **name** → `varchar(50)`  
- **createdOn** → `datetime`  

---
**Table Name:** `ExperienceLevel`

**Columns:**
- **expId** → `int` (Primary Key)  
- **expLevel** → `varchar(50)`  
- **expDesc** → `varchar(50)`  
- **createdOn** → `datetime`  
- **createdBy** → `int`  

---

**Table Name:** `PriorityLevel`

**Columns:**
- **id** → `int` (Primary Key)  
- **name** → `varchar(20)`  
- **description** → `varchar(20)`  
- **createdOn** → `datetime`  
- **createdBy** → `int`  

---

**Table Name:** `InterviewReschedulingReason`

**Columns:**
- **id** → `int` (Primary Key)  
- **reason** → `varchar(50)`  
- **createdOn** → `datetime`  
- **createdBy** → `int`  
---

**Table Name:** `OfficeType`

**Columns:**
- **id** → `int` (Primary Key)  
- **name** → `varchar(20)`    
- **createdOn** → `datetime`  
- **createdBy** → `int`  

---

# JSON 

# MyProfile JSON 

**Section:** `About`
- **ProfessionalSummary** → `""`

**Section:** `Experience[]`
- **Title** → `""`  
- **CompanyName** → `""`  
- **EmploymentType** → `""`  
- **Location** → `""`  
- **Industry** → `""`  
- **EmploymentPeriod**  
  - **StartDate** → `""`  
  - **EndDate** → `""`  
- **RoleDescription**  
  - **JobDescription** → `""`  
  - **KeyAchievements** → `[]`  
  - **SkillsUsed** → `[]`  

**Section:** `Education[]`
- **SchoolOrCollegeName** → `""`  
- **Location** → `""`  
- **Degree** → `""`  
- **FieldOfStudy** → `""`  
- **DegreeType** → `""`  
- **DegreeStatus** → `""`  
- **TimelineAndPerformance**  
  - **StartDate** → `""`  
  - **EndDate** → `""`  
  - **Gpa** → `""`  
- **RelevantCourseWork** → `[]`  
- **Description** → `""`  
- **ActivitiesAndOrganizations** → `[]`  
- **AcademicAchievements** → `[]`  

**Section:** `Certifications[]`
- **Name** → `""`  
- **IssuingOrganization** → `""`  
- **IssueDate** → `""`  
- **ExpiryDate** → `""`  
- **CredentialId** → `""`  
- **VerificationUrl** → `""`  
- **Description** → `""`  
- **RelatedSkills** → `[]`  

**Section:** `Skills → SkillsExpertise[]`
- **CategoryName** → `""`  
- **SkillDetails[]**  
  - **SkillName** → `""`  
  - **Experience** → `""`  
  - **ProficiencyLevel** → `""`  
  - **LastUsed** → `""`  
  - **IsVerified** → `""`  
  - **YearsOfExperience** → `""`  

**Section:** `Projects[]`
- **ProjectName** → `""`  
- **ProjectCategory** → `""`  
- **ProjectDescription** → `""`  
- **TechnologiesUsed** → `[]`  
- **SourceCodeUrl** → `""`  
- **LiveDemoUrl** → `""`  
- **ProjectStatusAndTimeline**  
  - **Status** → `""`  
  - **StartDate** → `""`  
  - **EndDate** → `""`  
  - **KeyFeatures** → `[]`  
- **AdditionalDetails**  
  - **ChallengesFaced** → `""`  
  - **KeyLearnings** → `""`  
---

# Apply Job Json

**Section:** `PersonInformation`
- **firstName** → `""`  
- **lastName** → `""`  
- **email** → `""`  
- **phone** → `""`  
- **location** → `""`  
- **linkedinUrl** → `""`  
- **portfolioUrl** → `""`  

**Section:** `ExperienceAndBackground`
- **currentJobTitle** → `""`  
- **currentCompany** → `""`  
- **yearsOfExperience** → `""`  
- **expectedSalary** → `""`  
- **availabilityDate** → `""`  

**Section:** `AdditionalQuestions`
- **whatMotivatesYouToApplyForThisSpecificRole** → `""`  
- **doYouHaveExperienceWorkingRemotely** → `[]`  
- **whenCanYouStart** → `[]` 
---

# Company Profile Json

**Section:** `Overview`
- **CompanyName** → `""`  
- **Industry** → `""`  
- **Companysize** → `""`  
- **Location** → `""`  

**Section:** `ContactInformation`
- **website** → `""`  
- **Email** → `""`  
- **Phone** → `""`  

**Section:** `AboutUs`
- **CompanyDescription** → `""`  
- **MissionStatement** → `""`  

**Section:** `CultureValues`
- **CompanyValues** → `[]`  
- **CompanyCulture** → `""`  

**Section:** `Benefits`
- **EmployeeBenefits** → `[]`  

**Section:** `Office`
- **OfficeInformation**
  - **OfficeName** → `""`  
  - **OfficeType** → `""`  
  - **Description** → `""`  

- **AddressLocation**
  - **streetAddress** → `""`  
  - **City** → `""`  
  - **State** → `""`  
  - **Zip/Postal code** → `""`  
  - **Country** → `""`  

- **ContactCapacity**
  - **Phonenumber** → `""`  
  - **EmailAddress** → `""`  
  - **TotalCapacity** → `""`  
  - **CurrentEmployees** → `""`  
  - **WorkingHours Start** → `""`  
  - **WorkingHours End** → `""`  

- **OfficeAmenities**
  - **QuickAdd** → `[]`  

---
# Job Description

**Section:** `JobDescription`
- **Description** → `""`  
- **requiredSkills** → `[]`  
- **jobRequirements** → `[]`  

**Section:** `ApplicationDetails`
- **deadline** → `""`  
- **Benefits** → `[]`  
- **jobSetting**
- **priorityLevel** → `""`  

---
# Interview Feedback Json

**Section:** `InterviewFeedback`

- **PerformanceRating**
  - **TechnicalSkills** → `""`  
  - **Communication** → `""`  
  - **ExperienceLevel** → `""`  
  - **CulturalFit** → `""`  
  - **OverallAssessment** → `""`  

- **DetailedFeedback**
  - **GeneralComments** → `[]`  
  - **KeyStrengths** → `[]`  
  - **AreasForImprovement** → `[]`  
  - **AdditionalInterviewerNotes** → `[]`  

- **Recommendation**
  - **HiringRecommendation** → `""`  
  - **RecommendedNextSteps** → `[]`  

---
# Screening Json 
---
 - **ScreeningType** → `""`  
 - **AssignTo** → `""`  
 - **PriorityLevel** → `""`
 - **SchedulingPreference** →`""`
 - **AdditionalNotes** → `""`

---
# InterviewProcess Json 
---
 - **InterviewProcess**  →
      - **InterviewRounds**  →
         - **RoundTittle**:`""`,
         - **InterviewType**:`""`,
         - **Description**:`""`,
         - **Duration**:`""`,
         - **Interviewvers**:`""`,
         - **Instructions**:`""`,
---


```mermaid
 Status Tree for EliteHire

 Application Status

  For  Candidate:
    Application-Status --> Applied
    Application-Status --> Not Applied
    Applied --> Screening
    Screening --> Intereview
    Interview --> under review
    under review --> Offered
    under review --> Rejected

    Recjected Paths:
    Applied --> Rejected
    Screening --> Rejected
    Interview --> Rejected
  
  For Recruiter:
      Application-status --> NewApplication
      NewApplication --> Screening
      Screening --> Interview
      Review --> Interview
      Interview --> Rejected
      Interview--> Offered

    Recjected Paths:
    NewApplication --> Rejected
    Screening --> Rejected
    Interview --> Rejected


Interview Status

   Scheduled --> Completed
   Scheduled --> Rescheduled
   Scheduled --> Cancelled
   Scheduled --> Not Attended

Job Status

    Draft --> Active
    Draft --> Inactive/Closed
    Active --> OnHold
    OnHold --> Archived
    Review[Review (abnormal)] --> Active
    Review --> Rejected









