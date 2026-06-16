# C-project-25.3-year1-sem-2
This repo is using to update and manage the C# project .

Step 1 :
download xamp app and install it in to your computer.
  resource : https://www.apachefriends.org/download.html

Step 2 :
  download the  github desktop app.
    resource : https://desktop.github.com/download/
    
Step 3 :
  install the github desktop and setup it.
  
Step 4 :
  pull the C-project-25.3-year1-sem-2 repository to your local machine.
  
Step 5 : 
  start working on the project with your part with pre-made file structure.


Structure and documentation

TempleManagementSystem
│
├── Program.cs
├── TempleManagementSystem.sln
│
├── Core                         ⭐ Member 1
│   │
│   ├── Models
│   │   ├── TempleEntity.cs
│   │   └── User.cs
│   │
│   ├── Interfaces
│   │   ├── IRepository.cs
│   │   └── IService.cs
│   │
│   ├── Collections
│   │   └── CollectionManager.cs
│   │
│   └── FileHandling
│       └── FileManager.cs
│
│
├── Modules
│   │
│   ├── EventManagement             ⭐ Member 2
│   │   │
│   │   ├── Event.cs
│   │   ├── EventService.cs
│   │   ├── EventManager.cs
│   │   └── EventRepository.cs
│   │
│   │
│   ├── DanaOfferingManagement       ⭐ Member 3
│   │   │
│   │   ├── DanaOffering.cs
│   │   ├── DanaService.cs
│   │   ├── DanaManager.cs
│   │   └── DanaRepository.cs
│   │
│   │
│   ├── ResourceManagement           ⭐ Member 4
│   │   │
│   │   ├── Resource.cs
│   │   ├── InventoryManager.cs
│   │   ├── ResourceService.cs
│   │   └── ResourceRepository.cs
│   │
│   │
│   ├── VisitorManagement            ⭐ Member 5
│   │   │
│   │   ├── Visitor.cs
│   │   ├── VisitorService.cs
│   │   ├── VisitorManager.cs
│   │   └── VisitorRepository.cs
│   │
│   │
│   └── SacredDayPlanner             ⭐ Member 6
│       │
│       ├── SacredDay.cs
│       ├── ReminderService.cs
│       ├── ChecklistManager.cs
│       └── PlannerRepository.cs
│
│
├── Database                        ⭐ Shared
│   │
│   ├── TempleDB.sql
│   ├── Tables.sql
│   └── SampleData.sql
│
│
├── UI                               ⭐ Member 8
│   │
│   ├── Forms
│   │   ├── MainForm.cs
│   │   ├── EventForm.cs
│   │   ├── DanaForm.cs
│   │   ├── ResourceForm.cs
│   │   ├── VisitorForm.cs
│   │   └── PlannerForm.cs
│   │
│   └── Dashboard.cs
│
│
├── Testing                          ⭐ Member 7
│   │
│   ├── TestCases.md
│   ├── TestData
│   └── BugReports.md
│
│
└── Documentation                    ⭐ Member 7
    │
    ├── ProjectReport.docx
    └── UserManual.docx



Member responsibilities mapped
👤 Member 1 — Project Lead & Core Architect

Works on:

Core/
Program.cs
Database connection setup

Creates:

Base classes
OOP structure
Collections
File handling

Example:

TempleEntity
     |
  --------
  |      |
Event Visitor

Handles:

Classes
Encapsulation
Inheritance
Polymorphism
👤 Member 2 — Event Management Developer

Works on:

Modules/EventManagement

Creates:

Add event
Update event
Delete event
View events
Schedule management
👤 Member 3 — Dana Offering Developer

Works on:

Modules/DanaOfferingManagement

Creates:

Donor records
Dana schedules
Meal arrangements
Completed/upcoming dana tracking
👤 Member 4 — Resource Management Developer

Works on:

Modules/ResourceManagement

Creates:

Resource inventory
Quantity tracking
Add/remove stock
Resource usage
👤 Member 5 — Visitor Management Developer

Works on:

Modules/VisitorManagement

Creates:

Visitor registration
Visitor history
Visitor schedule
👤 Member 6 — Sacred Day Planner Developer

Works on:

Modules/SacredDayPlanner

Creates:

Sacred day calendar
Reminder system
Preparation checklist
Volunteer reminders
👤 Member 7 — QA & Integration Lead

Works on:

Testing/
Documentation/

Creates:

Test cases
Bug reports
Final documentation
Integration testing

Checks:

Data duplication
Wrong schedules
Module communication
👤 Member 8 — UI & Data Flow Specialist

Works on:

UI/

Creates:

Windows Forms
Dashboards
Navigation
User experience

Connects:

UI
 |
Services
 |
Data
 |
Database

This structure matches the assignment roles exactly and is simple enough for a C# Visual Studio project.




