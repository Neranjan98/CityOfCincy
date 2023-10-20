# **City of Cincinnati Information Application**

---

## Introduction

The City of Cincinnati Information Application e­xtends a warm welcome to visitors. This compre­hensive repository house­s the source code and re­sources for our user-friendly we­b application, dedicated to providing vital information about city departme­nts and services. Our mission is to make it easy for users to access essential information about job positions, department directors, department missions, contact details, and office locations within the City of Cincinnati.

City of Cincinnati Information Application will help you:
1. Get Salary range for a given position in City of Cincinnati.
2. Check who is the director of the given department.
3. Get the mission of the deparment.
4. Suggest who you can reach out to for if you have any questions.
5. Get the location of City of Cincinnati office.

## Data Feeds

[City of Cincinnati Salary Schedule - ](https://data.cincinnati-oh.gov/Efficient-Service-Delivery/City-of-Cincinnati-Employees-w-Salaries/wmj4-ygbf)


[City of Cincinnati Department Information - ](https://data.cincinnati-oh.gov/Efficient-Service-Delivery/City-of-Cincinnati-Department-Information/txnn-6e6x)


[City of Cincinnati Employees w/ Salaries - ](https://data.cincinnati-oh.gov/Efficient-Service-Delivery/City-of-Cincinnati-Salary-Schedule/yaws-h72m)


[City of Cincinnati office location - ](https://developers.google.com/maps/documentation/embed/get-started)



## Functional Requirements

 1. Requirement 100.0: Search for Salary range
    
     Scenario:
        As a user interested in salary information, I want to be able to search for salary data based on various criteria, including job position and department names.
    
     Dependencies:
        Salary related data sources are avaiable and accessible.
    
     Assumptions:
        Job Positions and Deparment names are stated in English.
   
     Examples:
    
      1.1 
          Given a feed of salary data availabe
          When I search for "Project Manager - Construction"
          Then I should recieve at least one result with these attributes:


       Job Position: Project Manager - Construction
       Department: Civil Constructions
       Salary Range: $XX,XXX-$XX,XXXX per year

      1.2 
          Given a feed of salary data availabe
          When I search for "Police Officer"
          Then I should recieve at least one result with these attributes:

       Job Position: Police Officer
       Department: Public Safety Department
       Salary Range: $XX,XXX-$XX,XXXX per year

      1.3
          Given a feed of salary data availabe
          When I search for "521 Martin Luther King Street"
          Then I should recieve zero results(an empty list)

 2. Requirement 101.0: Search for Department Information
    
     Scenario:
        As a user interested in department related information, I want to be able to search for department data based on various criteria, department names and department office location.
    
     Dependencies:
        Department related data sources are avaiable and accessible.
    
     Assumptions:
        Deparment names are stated in English.

     Examples
    
      1.1 
         Given a feed of department data availabe
         When I search for "Public Safety Department"
         Then I should recieve at least one result with these attributes:

       Department Name: Public Safety Department
       Department Mission: Safe and Secure City of Cincinnati
       Department Director: Jack Jones 

      1.2 
         Given a feed of department data availabe
         When I search for "City Planning"
         Then I should recieve at least one result with these attributes:

       Department Name: City Planning
       Department Mission: To utilize creative planning principles, to guide land use while 
                           ensuring excellent customer service and fostering safe and sustainable 
                           building development.
       Department Director: Hrishi Anil

       1.3
         Given a feed of salary data availabe
         When I search for "123 Harris"
         Then I should recieve zero results(an empty list)

 3. Requirement 102.0: Search for Department Office Location
      Scenario:
        As a user interested in office location information, I want to be able to search for location data based on various criteria, including Office and Department Names.
    
       Dependencies:
        Office location related data sources are avaiable and accessible.
    
       Assumptions
        Office Location names are stated in English.

       Examples
    
       1.1 
         Given a feed of office location data availabe
         When I search for "City of Cincinnati Office"
         Then I should recieve at least one result with these attributes:

       Office Name: City of Cincinnati Police Office
       Location:    3300 Central Pkwy, Cincinnati, OH 45220  

       1.2 
         Given a feed of office location data availabe
         When I search for "Cincinnati Health Department"
         Then I should recieve at least one result with these attributes:

       Office Name: Cincinnati Health Department
       Location:    3101 Burnet Ave, Cincinnati, OH 45229 

       1.3
         Given a feed of office location data availabe
         When I search for "1234 Bishop street"
         Then I should recieve zero results(an empty list)


## Team Members

| M Number    | Team Member					  |
| ----------- | ----------------------------- |
| M15751827   | Neranjan Ramakrishnan Sugumar |
| M15583739   | Hrishikesh Anil Patil		  |
| M15446777   | Ramvyasa Thavasiraj			  |
| M15916169   | Bandhavi Aakasapu			  |
| M15744432   | Sweta	Pandya					  |

## Scrum Roles 

Product Owner:         Bandhavi Aakasapu
Scrum Master:          Sweta	Pandya
Frontend Developer:    Ramvyasa Thavasiraj
Backend Developer:     Neranjan Ramakrishnan Sugumar
Business Analyst:      Hrishikesh Anil Patil

##  Weekly Meeting

Monday at 11 AM on Teams

