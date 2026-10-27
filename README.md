# AutoRent — Motor Vehicle Sales Management (WPF, C#)

Desktop application for a motorcycle / motor-vehicle dealership, built as my diploma project (2021).
It manages the vehicle catalogue, clients, employees and sales, with role-based access and Word report generation.

## Download

A ready-to-run Windows build is available on the [Releases](../../releases) page — no Visual Studio needed.

## Features

- **Authorization** with roles (Administrator, Director, Manager) and a captcha after 3 failed login attempts
- **Administrator**: full CRUD for vehicles, models, manufacturers, countries, colors, clients, employees, roles, statuses and payment types
- **Manager**: vehicle catalogue, clients and sales registration, receipt printing
- **Director**: sales reports
- **Word export**: sales reports and receipts (DocX / MS Word Interop)
- Material Design UI

## Tech stack

- C#, WPF, .NET Framework 4.7.2
- MySQL / MariaDB (`MySql.Data` 8.0.21)
- MaterialDesignThemes, DocX (Xceed), Microsoft Office Interop Word

## Project structure

```
AutoRent.sln
AutoRent/            WPF project (windows: Avtr, MainWindow, Manager, Window1)
AutoRent/lib/MySql/  MySql.Data and its dependencies
database/mototex.sql Database schema + demo data
```

## How to run

### Ready build (from Releases)

1. Install **XAMPP** and start MySQL (root with empty password — XAMPP default).
2. Import `mototex.sql` in phpMyAdmin (Import tab). It creates the `mototex` database.
3. Run `AutoRent.exe`.

### From source

1. Import `database/mototex.sql` as above.
2. Open `AutoRent.sln` in **Visual Studio 2019/2022** with the ".NET desktop development" workload.
3. If your MySQL root user has a password, set it in `AutoRent/App.config` (`connectionStrings` → `mototex`).
4. Build and run (F5). NuGet packages are restored automatically.

Microsoft Word must be installed for building (Office Interop) and for report export.

### Demo accounts

| Role          | Login | Password |
|---------------|-------|----------|
| Administrator | a     | a        |
| Director      | d     | d        |
| Manager       | m     | m        |

## Notes

This is a student project. Known limitations: SQL queries are built with string concatenation (no parameters),
and passwords are stored in plain text in the demo database.

## Author

Artem Titov
