
CREATE DATABASE [TempleManagementDB]
GO

-- ============================================================
-- Everything below runs inside the new database via sqlcmd
-- The :setvar and :connect trick forces a new connection
-- context after CREATE DATABASE, avoiding the parse-time error.
-- We use a single sp_executesql block routed into the new DB.
-- ============================================================

DECLARE @sql NVARCHAR(MAX) = N'
USE [TempleManagementDB];

-- TABLES

CREATE TABLE [dbo].[Roles](
    [RoleID]   INT IDENTITY(1,1) NOT NULL,
    [RoleName] NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Roles PRIMARY KEY ([RoleID])
);
ALTER TABLE [dbo].[Roles] ADD UNIQUE ([RoleName]);

CREATE TABLE [dbo].[Users](
    [UserID]           INT IDENTITY(1,1) NOT NULL,
    [FullName]         NVARCHAR(100) NOT NULL,
    [Username]         NVARCHAR(50)  NOT NULL,
    [Email]            NVARCHAR(100) NULL,
    [PasswordHash]     NVARCHAR(255) NOT NULL,
    [ContactNumber]    NVARCHAR(15)  NULL,
    [Address]          NVARCHAR(255) NULL,
    [ProfileImagePath] NVARCHAR(255) NULL,
    [RoleID]           INT NOT NULL,
    [IsActive]         BIT NOT NULL CONSTRAINT DF_Users_IsActive DEFAULT (1),
    [CreatedDate]      DATETIME NOT NULL CONSTRAINT DF_Users_CreatedDate DEFAULT (GETDATE()),
    CONSTRAINT PK_Users PRIMARY KEY ([UserID]),
    CONSTRAINT FK_Users_Roles FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Roles]([RoleID])
);
ALTER TABLE [dbo].[Users] ADD UNIQUE ([Username]);
ALTER TABLE [dbo].[Users] ADD UNIQUE ([Email]);

CREATE TABLE [dbo].[Visitors](
    [VisitorID]     INT IDENTITY(1,1) NOT NULL,
    [FullName]      NVARCHAR(100) NOT NULL,
    [ContactNumber] NVARCHAR(15)  NULL,
    [Email]         NVARCHAR(100) NULL,
    [NICNumber]     NVARCHAR(20)  NULL,
    [Address]       NVARCHAR(255) NULL,
    [CreatedDate]   DATETIME NOT NULL CONSTRAINT DF_Visitors_CreatedDate DEFAULT (GETDATE()),
    CONSTRAINT PK_Visitors PRIMARY KEY ([VisitorID])
);

CREATE TABLE [dbo].[SacredDays](
    [SacredDayID]         INT IDENTITY(1,1) NOT NULL,
    [DayName]             NVARCHAR(100) NOT NULL,
    [SacredDate]          DATE NOT NULL,
    [Description]         NVARCHAR(255) NULL,
    [IsRecurringAnnually] BIT NOT NULL CONSTRAINT DF_SacredDays_IsRecurring DEFAULT (1),
    CONSTRAINT PK_SacredDays PRIMARY KEY ([SacredDayID])
);

CREATE TABLE [dbo].[EventTypes](
    [EventTypeID] INT IDENTITY(1,1) NOT NULL,
    [TypeName]    NVARCHAR(50)  NOT NULL,
    [Description] NVARCHAR(255) NULL,
    CONSTRAINT PK_EventTypes PRIMARY KEY ([EventTypeID])
);
ALTER TABLE [dbo].[EventTypes] ADD UNIQUE ([TypeName]);

CREATE TABLE [dbo].[Events](
    [EventID]     INT IDENTITY(1,1) NOT NULL,
    [EventTypeID] INT NOT NULL,
    [EventName]   NVARCHAR(150) NOT NULL,
    [EventDate]   DATE NOT NULL,
    [StartTime]   TIME(7) NULL,
    [EndTime]     TIME(7) NULL,
    [Location]    NVARCHAR(150) NULL,
    [Description] NVARCHAR(500) NULL,
    [OrganizedBy] INT NULL,
    [Status]      NVARCHAR(20)  NOT NULL CONSTRAINT DF_Events_Status DEFAULT (''Scheduled''),
    [CreatedDate] DATETIME NOT NULL CONSTRAINT DF_Events_CreatedDate DEFAULT (GETDATE()),
    [MonkCount]   INT NULL,
    [Offerings]   NVARCHAR(255) NULL,
    [Speaker]     NVARCHAR(100) NULL,
    [Topic]       NVARCHAR(150) NULL,
    [Sponsor]     NVARCHAR(100) NULL,
    [GuestCount]  INT NULL,
    CONSTRAINT PK_Events PRIMARY KEY ([EventID]),
    CONSTRAINT FK_Events_EventTypes FOREIGN KEY ([EventTypeID]) REFERENCES [dbo].[EventTypes]([EventTypeID]),
    CONSTRAINT FK_Events_Users      FOREIGN KEY ([OrganizedBy]) REFERENCES [dbo].[Users]([UserID]),
    CONSTRAINT CHK_Events_Status    CHECK ([Status] IN (''Scheduled'',''Completed'',''Cancelled''))
);

CREATE TABLE [dbo].[Donors](
    [DonorID]       INT IDENTITY(1,1) NOT NULL,
    [FullName]      NVARCHAR(100) NOT NULL,
    [ContactNumber] NVARCHAR(15)  NULL,
    [Email]         NVARCHAR(100) NULL,
    [Address]       NVARCHAR(255) NULL,
    [CreatedDate]   DATETIME NOT NULL CONSTRAINT DF_Donors_CreatedDate DEFAULT (GETDATE()),
    [UserID]        INT NULL,
    CONSTRAINT PK_Donors   PRIMARY KEY ([DonorID]),
    CONSTRAINT FK_Donors_Users FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users]([UserID])
);

CREATE TABLE [dbo].[DanaRequests](
    [RequestID]   INT IDENTITY(1,1) NOT NULL,
    [DonorID]     INT NOT NULL,
    [DanaDate]    DATE NOT NULL,
    [DanaType]    NVARCHAR(100) NOT NULL,
    [Status]      NVARCHAR(50)  NOT NULL CONSTRAINT DF_DanaRequests_Status     DEFAULT (''Pending''),
    [RequestDate] DATETIME NOT NULL      CONSTRAINT DF_DanaRequests_RequestDate DEFAULT (GETDATE()),
    [MealType]    NVARCHAR(20)  NOT NULL CONSTRAINT DF_DanaRequests_MealType    DEFAULT (''Other''),
    CONSTRAINT PK_DanaRequests           PRIMARY KEY ([RequestID]),
    CONSTRAINT FK_DanaRequests_Donors    FOREIGN KEY ([DonorID]) REFERENCES [dbo].[Donors]([DonorID]),
    CONSTRAINT CHK_DanaRequests_MealType CHECK ([MealType] IN (''Breakfast'',''Lunch'',''Dinner'',''Other''))
);

CREATE TABLE [dbo].[MealArrangements](
    [MealID]       INT IDENTITY(1,1) NOT NULL,
    [RequestID]    INT NOT NULL,
    [MealType]     NVARCHAR(100) NOT NULL,
    [MonksCount]   INT NOT NULL CONSTRAINT DF_Meal_MonksCount   DEFAULT (0),
    [DevoteeCount] INT NOT NULL CONSTRAINT DF_Meal_DevoteeCount DEFAULT (0),
    CONSTRAINT PK_MealArrangements              PRIMARY KEY ([MealID]),
    CONSTRAINT FK_MealArrangements_DanaRequests FOREIGN KEY ([RequestID]) REFERENCES [dbo].[DanaRequests]([RequestID])
);

CREATE TABLE [dbo].[DanaOfferings](
    [DanaID]         INT IDENTITY(1,1) NOT NULL,
    [DonorID]        INT NOT NULL,
    [EventID]        INT NULL,
    [DanaDate]       DATE NOT NULL,
    [MealType]       NVARCHAR(20)  NOT NULL,
    [NumberOfPeople] INT NOT NULL      CONSTRAINT DF_DanaOfferings_NumPeople   DEFAULT (0),
    [Description]    NVARCHAR(255) NULL,
    [Status]         NVARCHAR(20)  NOT NULL CONSTRAINT DF_DanaOfferings_Status      DEFAULT (''Upcoming''),
    [CreatedDate]    DATETIME NOT NULL      CONSTRAINT DF_DanaOfferings_CreatedDate DEFAULT (GETDATE()),
    [MealID]         INT NULL,
    CONSTRAINT PK_DanaOfferings                  PRIMARY KEY ([DanaID]),
    CONSTRAINT FK_Dana_Donors                    FOREIGN KEY ([DonorID]) REFERENCES [dbo].[Donors]([DonorID]),
    CONSTRAINT FK_Dana_Events                    FOREIGN KEY ([EventID]) REFERENCES [dbo].[Events]([EventID]),
    CONSTRAINT FK_DanaOfferings_MealArrangements FOREIGN KEY ([MealID])  REFERENCES [dbo].[MealArrangements]([MealID]),
    CONSTRAINT CHK_DanaOfferings_MealType CHECK ([MealType] IN (''Breakfast'',''Lunch'',''Dinner'',''Other'')),
    CONSTRAINT CHK_DanaOfferings_Status   CHECK ([Status]   IN (''Upcoming'',''Completed'',''Cancelled''))
);

CREATE TABLE [dbo].[ResourceCategories](
    [CategoryID]   INT IDENTITY(1,1) NOT NULL,
    [CategoryName] NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_ResourceCategories PRIMARY KEY ([CategoryID])
);
ALTER TABLE [dbo].[ResourceCategories] ADD UNIQUE ([CategoryName]);

CREATE TABLE [dbo].[Resources](
    [ResourceID]        INT IDENTITY(1,1) NOT NULL,
    [CategoryID]        INT NOT NULL,
    [ResourceName]      NVARCHAR(100) NOT NULL,
    [Unit]              NVARCHAR(20)  NOT NULL CONSTRAINT DF_Resources_Unit         DEFAULT (''pcs''),
    [QuantityAvailable] DECIMAL(10,2) NOT NULL CONSTRAINT DF_Resources_Qty          DEFAULT (0),
    [MinimumThreshold]  DECIMAL(10,2) NOT NULL CONSTRAINT DF_Resources_MinThreshold DEFAULT (0),
    [Description]       NVARCHAR(255) NULL,
    CONSTRAINT PK_Resources            PRIMARY KEY ([ResourceID]),
    CONSTRAINT FK_Resources_Categories FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[ResourceCategories]([CategoryID])
);

CREATE TABLE [dbo].[PreparationTasks](
    [TaskID]          INT IDENTITY(1,1) NOT NULL,
    [SacredDayID]     INT NULL,
    [EventID]         INT NULL,
    [TaskName]        NVARCHAR(150) NOT NULL,
    [TaskDescription] NVARCHAR(255) NULL,
    [AssignedTo]      INT NULL,
    [DueDate]         DATE NULL,
    [Priority]        NVARCHAR(10) NOT NULL CONSTRAINT DF_Tasks_Priority DEFAULT (''Medium''),
    [Status]          NVARCHAR(20) NOT NULL CONSTRAINT DF_Tasks_Status   DEFAULT (''Pending''),
    CONSTRAINT PK_PreparationTasks PRIMARY KEY ([TaskID]),
    CONSTRAINT FK_Tasks_Events     FOREIGN KEY ([EventID])     REFERENCES [dbo].[Events]([EventID]),
    CONSTRAINT FK_Tasks_SacredDays FOREIGN KEY ([SacredDayID]) REFERENCES [dbo].[SacredDays]([SacredDayID]),
    CONSTRAINT FK_Tasks_Users      FOREIGN KEY ([AssignedTo])  REFERENCES [dbo].[Users]([UserID]),
    CONSTRAINT CHK_Tasks_Priority  CHECK ([Priority] IN (''Low'',''Medium'',''High'')),
    CONSTRAINT CHK_Tasks_Status    CHECK ([Status]   IN (''Pending'',''InProgress'',''Completed''))
);

CREATE TABLE [dbo].[Reminders](
    [ReminderID]      INT IDENTITY(1,1) NOT NULL,
    [SacredDayID]     INT NULL,
    [EventID]         INT NULL,
    [ReminderMessage] NVARCHAR(255) NOT NULL,
    [ReminderDate]    DATE NOT NULL,
    [IsSent]          BIT NOT NULL     CONSTRAINT DF_Reminders_IsSent      DEFAULT (0),
    [CreatedDate]     DATETIME NOT NULL CONSTRAINT DF_Reminders_CreatedDate DEFAULT (GETDATE()),
    CONSTRAINT PK_Reminders            PRIMARY KEY ([ReminderID]),
    CONSTRAINT FK_Reminders_Events     FOREIGN KEY ([EventID])     REFERENCES [dbo].[Events]([EventID]),
    CONSTRAINT FK_Reminders_SacredDays FOREIGN KEY ([SacredDayID]) REFERENCES [dbo].[SacredDays]([SacredDayID])
);

CREATE TABLE [dbo].[ResourceTransactions](
    [TransactionID]   INT IDENTITY(1,1) NOT NULL,
    [ResourceID]      INT NOT NULL,
    [TransactionType] NVARCHAR(10)  NOT NULL,
    [Quantity]        DECIMAL(10,2) NOT NULL,
    [TransactionDate] DATETIME NOT NULL CONSTRAINT DF_Transactions_Date DEFAULT (GETDATE()),
    [Purpose]         NVARCHAR(255) NULL,
    [HandledBy]       INT NULL,
    CONSTRAINT PK_ResourceTransactions   PRIMARY KEY ([TransactionID]),
    CONSTRAINT FK_Transactions_Resources FOREIGN KEY ([ResourceID]) REFERENCES [dbo].[Resources]([ResourceID]),
    CONSTRAINT FK_Transactions_Users     FOREIGN KEY ([HandledBy])  REFERENCES [dbo].[Users]([UserID]),
    CONSTRAINT CHK_TransactionType       CHECK ([TransactionType] IN (''IN'',''OUT''))
);

CREATE TABLE [dbo].[SystemSettings](
    [SettingID]    INT IDENTITY(1,1) NOT NULL,
    [SettingKey]   NVARCHAR(100) NOT NULL,
    [SettingValue] NVARCHAR(255) NOT NULL,
    [Description]  NVARCHAR(255) NULL,
    CONSTRAINT PK_SystemSettings PRIMARY KEY ([SettingID])
);
ALTER TABLE [dbo].[SystemSettings] ADD UNIQUE ([SettingKey]);

CREATE TABLE [dbo].[VisitorVisits](
    [VisitID]      INT IDENTITY(1,1) NOT NULL,
    [VisitorID]    INT NOT NULL,
    [EventID]      INT NULL,
    [VisitDate]    DATE NOT NULL,
    [Purpose]      NVARCHAR(150) NULL,
    [CheckInTime]  TIME(7) NULL,
    [CheckOutTime] TIME(7) NULL,
    [Notes]        NVARCHAR(255) NULL,
    CONSTRAINT PK_VisitorVisits   PRIMARY KEY ([VisitID]),
    CONSTRAINT FK_Visits_Visitors FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitors]([VisitorID]),
    CONSTRAINT FK_Visits_Events   FOREIGN KEY ([EventID])   REFERENCES [dbo].[Events]([EventID])
);

-- VIEWS

EXEC(''CREATE VIEW [dbo].[vw_DashboardSummary] AS
SELECT
    (SELECT COUNT(*) FROM Events        WHERE Status = ''''Scheduled'''' AND EventDate >= CAST(GETDATE() AS DATE)) AS UpcomingEvents,
    (SELECT COUNT(*) FROM DanaOfferings WHERE Status = ''''Upcoming'''')  AS UpcomingDana,
    (SELECT COUNT(*) FROM Donors)        AS TotalDonors,
    (SELECT COUNT(*) FROM Visitors)      AS TotalVisitors,
    (SELECT COUNT(*) FROM Resources      WHERE QuantityAvailable <= MinimumThreshold) AS LowStockResources,
    (SELECT COUNT(*) FROM SacredDays     WHERE SacredDate >= CAST(GETDATE() AS DATE)) AS UpcomingSacredDays'');

EXEC(''CREATE VIEW [dbo].[vw_UpcomingSacredDays] AS
SELECT SacredDayID, DayName, SacredDate,
       DATEDIFF(DAY, CAST(GETDATE() AS DATE), SacredDate) AS DaysRemaining
FROM SacredDays WHERE SacredDate >= CAST(GETDATE() AS DATE)'');

EXEC(''CREATE VIEW [dbo].[vw_LowStockResources] AS
SELECT r.ResourceID, r.ResourceName, c.CategoryName, r.QuantityAvailable, r.MinimumThreshold
FROM Resources r JOIN ResourceCategories c ON r.CategoryID = c.CategoryID
WHERE r.QuantityAvailable <= r.MinimumThreshold'');

EXEC(''CREATE VIEW [dbo].[vw_TodayEvents] AS
SELECT e.EventID, e.EventName, et.TypeName, e.StartTime, e.Location
FROM Events e JOIN EventTypes et ON e.EventTypeID = et.EventTypeID
WHERE e.EventDate = CAST(GETDATE() AS DATE) AND e.Status = ''''Scheduled'''' '');

-- SEED DATA

SET IDENTITY_INSERT [dbo].[Roles] ON;
INSERT [dbo].[Roles] ([RoleID],[RoleName]) VALUES (1,N''Admin'');
INSERT [dbo].[Roles] ([RoleID],[RoleName]) VALUES (2,N''Donor'');
SET IDENTITY_INSERT [dbo].[Roles] OFF;

SET IDENTITY_INSERT [dbo].[Users] ON;
INSERT [dbo].[Users] ([UserID],[FullName],[Username],[Email],[PasswordHash],[ContactNumber],[Address],[ProfileImagePath],[RoleID],[IsActive],[CreatedDate])
VALUES (1,N''System Administrator'',N''admin'',N''admin@gmail.com'',N''admin123'',N''0771234567'',N''Colombo'',NULL,1,1,CAST(N''2026-06-26T09:21:19.727'' AS DATETIME));
INSERT [dbo].[Users] ([UserID],[FullName],[Username],[Email],[PasswordHash],[ContactNumber],[Address],[ProfileImagePath],[RoleID],[IsActive],[CreatedDate])
VALUES (2,N''Janindu Ranathunga'',N''Janix160R'',N''janinduac@gmail.com'',N''Janiya@123'',N''0752377679'',N''No. 8 Suddharmarama road'',NULL,1,1,CAST(N''2026-06-27T00:00:00.000'' AS DATETIME));
SET IDENTITY_INSERT [dbo].[Users] OFF;

SET IDENTITY_INSERT [dbo].[EventTypes] ON;
INSERT [dbo].[EventTypes] ([EventTypeID],[TypeName],[Description]) VALUES (1,N''Religious Ceremony'',NULL);
INSERT [dbo].[EventTypes] ([EventTypeID],[TypeName],[Description]) VALUES (2,N''Meditation Program'',NULL);
INSERT [dbo].[EventTypes] ([EventTypeID],[TypeName],[Description]) VALUES (3,N''Dana Program'',NULL);
INSERT [dbo].[EventTypes] ([EventTypeID],[TypeName],[Description]) VALUES (4,N''Special Event'',NULL);
SET IDENTITY_INSERT [dbo].[EventTypes] OFF;

SET IDENTITY_INSERT [dbo].[Events] ON;
INSERT [dbo].[Events] ([EventID],[EventTypeID],[EventName],[EventDate],[StartTime],[EndTime],[Location],[Description],[OrganizedBy],[Status],[CreatedDate],[MonkCount],[Offerings],[Speaker],[Topic],[Sponsor],[GuestCount])
VALUES (2,1,N''Nikini Poya Sil Program'',CAST(N''2026-07-30'' AS DATE),CAST(N''08:00:00'' AS TIME),CAST(N''17:00:00'' AS TIME),N''Main Dhamma Hall'',N''One day Sil campaign for devotees.'',1,N''Scheduled'',CAST(N''2026-06-26T09:22:33.510'' AS DATETIME),12,N''Rice, Fruits, Flowers'',N''Ven. Dhammaseela Thero'',N''Importance of Sil'',N''ABC Traders'',150);
INSERT [dbo].[Events] ([EventID],[EventTypeID],[EventName],[EventDate],[StartTime],[EndTime],[Location],[Description],[OrganizedBy],[Status],[CreatedDate],[MonkCount],[Offerings],[Speaker],[Topic],[Sponsor],[GuestCount])
VALUES (3,1,N''Nikini Poya Sil Program'',CAST(N''2026-07-30'' AS DATE),CAST(N''08:00:00'' AS TIME),CAST(N''17:00:00'' AS TIME),N''Main Dhamma Hall'',N''One day Sil campaign for devotees.'',1,N''Scheduled'',CAST(N''2026-06-26T09:22:37.407'' AS DATETIME),12,N''Rice, Fruits, Flowers'',N''Ven. Dhammaseela Thero'',N''Importance of Sil'',N''ABC Traders'',150);
SET IDENTITY_INSERT [dbo].[Events] OFF;

SET IDENTITY_INSERT [dbo].[ResourceCategories] ON;
INSERT [dbo].[ResourceCategories] ([CategoryID],[CategoryName]) VALUES (1,N''Robes & Requisites'');
INSERT [dbo].[ResourceCategories] ([CategoryID],[CategoryName]) VALUES (2,N''Food Items'');
INSERT [dbo].[ResourceCategories] ([CategoryID],[CategoryName]) VALUES (3,N''Stationery'');
INSERT [dbo].[ResourceCategories] ([CategoryID],[CategoryName]) VALUES (4,N''Medical Supplies'');
INSERT [dbo].[ResourceCategories] ([CategoryID],[CategoryName]) VALUES (5,N''Other'');
SET IDENTITY_INSERT [dbo].[ResourceCategories] OFF;

SET IDENTITY_INSERT [dbo].[SystemSettings] ON;
INSERT [dbo].[SystemSettings] ([SettingID],[SettingKey],[SettingValue],[Description]) VALUES (1,N''TempleName'',N''Sri Sambodhi Viharaya'',N''Display name shown across the system'');
INSERT [dbo].[SystemSettings] ([SettingID],[SettingKey],[SettingValue],[Description]) VALUES (2,N''ReminderDaysBefore'',N''3'',N''Days before a Sacred Day to trigger reminders'');
INSERT [dbo].[SystemSettings] ([SettingID],[SettingKey],[SettingValue],[Description]) VALUES (3,N''LowStockThreshold'',N''1'',N''Toggle low-stock alerts on the dashboard'');
SET IDENTITY_INSERT [dbo].[SystemSettings] OFF;

PRINT ''TempleManagementDB setup complete!'';
';

EXEC [master]..sp_executesql @sql;
GO
