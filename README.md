# Sentialx

## Event-Driven Threat Monitoring & Logging System

A comprehensive Windows Forms application built in C# that monitors external systems by importing their log files, analyzing events in real-time, and detecting security threats automatically.

---

## 📋 Project Overview

**Sentralx** is a desktop application designed to serve as a centralized security monitoring hub. It imports logs from external systems (firewalls, web servers, databases), stores them in a relational database, and applies intelligent threat detection rules to identify suspicious behavior patterns.

### Key Features:
- ✅ Real-time event logging and analysis
- ✅ Automated threat detection (4 detection rules)
- ✅ CSV log file import from external systems
- ✅ Role-based access control (Admin/User)
- ✅ SQL Database integration with normalized tables
- ✅ Alert management and resolution
- ✅ Activity reporting and filtering
- ✅ Secure password hashing (SHA-256)

---

## 🏗️ Architecture

### 3-Tier Architecture:

**Presentation Layer (9 Forms)**
- LoginForm
- DashboardForm
- UserManagementForm
- EventViewerForm
- AlertsForm
- FilterSearchForm
- ReportGeneratorForm
- EventLoggerForm
- LogImporterForm

**Business Logic Layer (9 Classes)**
- DatabaseHelper
- User
- EventLog
- Alert
- EventLogger
- ThreatDetector
- ReportFilter
- ReportGenerator
- LogImporter

**Data Access Layer**
- Microsoft SQL LocalDB
- 3 Normalized Tables (Users, Events, Alerts)

---

## 🗄️ Database Design

### Users Table
- UserID (PK, Identity)
- Username (Unique)
- PasswordHash (SHA-256)
- Role (Admin/User)
- CreatedAt (Default: GETDATE())

### Events Table
- EventID (PK, Identity)
- UserID (FK → Users)
- EventType (Login/FailedLogin/Action/Delete/Error)
- Description
- Timestamp (Default: GETDATE())

### Alerts Table
- AlertID (PK, Identity)
- EventID (FK → Events)
- AlertType (BruteForce/MassDelete/SuspiciousActivity/SystemInstability)
- Severity (High/Medium)
- IsResolved (0/1)
- Timestamp (Default: GETDATE())

---

## 🚀 Threat Detection Engine

### 4 Detection Rules:

| Rule | Condition | Severity |
|------|-----------|----------|
| **BruteForce** | 3+ failed logins within 60 seconds | High |
| **SuspiciousActivity** | 10+ actions within 60 seconds | Medium |
| **MassDelete** | 3+ deletes within 60 seconds | High |
| **SystemInstability** | 5+ errors within 60 seconds | Medium |

### How It Works:
1. Event is logged to database
2. ThreatDetector.CheckRules() called automatically
3. Event evaluated against all 4 rules
4. If threshold exceeded → Alert created
5. Admin sees alert in Alerts Form
6. Admin resolves alert

---

## 📥 CSV Log Import

### Feature:
Import logs from external systems (Firewall, Web Server, Database, etc.)

### CSV Format:
```
Timestamp,UserID,EventType,Description
2026-06-01 10:05:00,1,FailedLogin,Wrong password
2026-06-01 10:05:05,1,FailedLogin,Wrong password
2026-06-01 10:05:10,1,FailedLogin,Wrong password
```

### Process:
1. User selects CSV file in LogImporter Form
2. File validated (format, event types, users)
3. Events inserted with **original timestamp**
4. ThreatDetector runs on each event
5. Threats detected automatically

### Key Design:
- Uses original timestamp from CSV (not DateTime.Now)
- Allows accurate threat detection on historical data
- Supports monitoring any external system that exports CSV

---

## 🔐 Security Features

- ✅ SHA-256 password hashing (not stored in plain text)
- ✅ SQL Parameterized queries (prevents SQL Injection)
- ✅ Role-based access control
- ✅ Full audit trail (all events logged)
- ✅ Duplicate alert prevention

---

## 👥 Team Members

| Name | Student ID | Role |
|------|-----------|------|
| Ammar Samy Abdelkader | 42010289 | Database & Classes |
| Kamal Abdelgawad | 42310032 | |
| Abdelrahman Morsy | 42020008 | |
| Aziz Sayed | 42310533 | |
| Abdullah Ibrahim Harb | 42010669 | |
| Hossam Mahmoud | 42020003 | |

**Supervised by:** Dr. Ahmed Seif

---

## 🛠️ Technologies Used

- **Language:** C# (.NET Core/NET 5+)
- **UI Framework:** Windows Forms
- **Database:** Microsoft SQL Server LocalDB
- **Encryption:** SHA-256 (System.Security.Cryptography)
- **NuGet Package:** Microsoft.Data.SqlClient

---

## 📦 Project Structure

```
Sentralx/
├── Classes/
│   ├── DatabaseHelper.cs
│   ├── User.cs
│   ├── EventLog.cs
│   ├── Alert.cs
│   ├── EventLogger.cs
│   ├── ThreatDetector.cs
│   ├── ReportFilter.cs
│   ├── ReportGenerator.cs
│   └── LogImporter.cs
├── Forms/
│   ├── LoginForm.cs
│   ├── DashboardForm.cs
│   ├── UserManagementForm.cs
│   ├── EventViewerForm.cs
│   ├── AlertsForm.cs
│   ├── FilterSearchForm.cs
│   ├── ReportGeneratorForm.cs
│   ├── EventLoggerForm.cs
│   └── LogImporterForm.cs
├── Program.cs
├── App.config
└── Sentralx.csproj
```

---

## 🚀 How to Run

### Prerequisites:
- Visual Studio 2019 or later
- .NET Core/.NET 5 or higher
- Microsoft SQL Server LocalDB (included with Visual Studio)

### Steps:
1. Clone the repository
   ```bash
   git clone https://github.com/iamben-spec/-sentralx.git
   ```

2. Open `Sentralx.sln` in Visual Studio

3. Build the solution
   ```
   Build → Build Solution (Ctrl+Shift+B)
   ```

4. Run the application
   ```
   Press F5 or Debug → Start Debugging
   ```

5. Login with default credentials:
   - Username: `admin`
   - Password: `admin123`

---

## 💡 Key Design Decisions

### 1. Event-Driven Architecture
- Every action triggers an event
- ThreatDetector evaluates immediately
- Real-time threat detection

### 2. Dual Timestamp Handling
- Live events: Use DateTime.Now
- CSV events: Use original timestamp
- Allows accurate analysis of historical data

### 3. Static DatabaseHelper
- Single point of database access
- Prevents duplicate connections
- Centralized error handling

### 4. Parameterized SQL Queries
- Prevents SQL Injection
- Type-safe data binding
- Database portability

### 5. Normalized Database Design
- 3 tables with proper relationships
- Maintains data integrity (Foreign Keys)
- Scalable structure

---

## 📊 Sample Workflow

```
1. Firewall exports log file (CSV)
   ↓
2. Admin opens LogImporter Form
   ↓
3. Admin selects and imports CSV file
   ↓
4. LogImporter validates each record
   ↓
5. Events inserted into database (with original timestamp)
   ↓
6. ThreatDetector analyzes each event
   ↓
7. If threat detected → Alert created
   ↓
8. Admin views alerts in Alerts Form
   ↓
9. Admin resolves alert
   ↓
10. System ready for next import
```

---

## 🎓 Learning Outcomes

This project demonstrates:
- ✅ Event-driven programming architecture
- ✅ Object-oriented design principles
- ✅ Relational database design
- ✅ Windows Forms GUI development
- ✅ Real-world SIEM system concepts
- ✅ Security best practices
- ✅ Data validation and error handling
- ✅ Role-based access control

---

## 📝 Notes

- Database is created automatically on first run
- Admin user is seeded with default password
- All passwords stored as SHA-256 hashes
- CSV import supports historical data analysis
- Alert resolution doesn't delete records (audit trail)

---

## 📄 License

MIT License - See LICENSE file for details

---

## 📧 Contact

For questions or issues, contact the development team.

**GitHub:** https://github.com/iamben-spec/-sentralx

---

**Last Updated:** June 2026
