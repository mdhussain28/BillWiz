# BillWiz - Inventory and Bill Management System

## Overview

BillWiz is an inventory and billing management system designed to streamline product tracking, sales management, and billing operations. This system helps businesses efficiently manage their stock and generate accurate invoices.

## Features

- Inventory Management
- Billing and Invoicing
- Sales Tracking
- Database Integration
- User-Friendly Interface
- Supports a resolution of 1920 x 1080

## Installation and Setup

### Prerequisites

- Windows OS
- SQL Server Management Studio (SSMS) and SQL Server
- .NET Framework 6.0

### Steps to Install

1. **Download the Executable**

   - Download and install `BillWiz_Setup.msi` from [GitHub Releases](https://github.com/adityavaibhavpawar/BillWiz/releases).

2. **Database Restoration**

   - Open **SQL Server Management Studio (SSMS)**.
   - You have two options to set up the database:
     1. **Restore from Backup File (.bak):**
        - In SSMS, right-click on **Databases** → **Restore Database**.
        - Select **Device**, browse, and choose the `.bak` file provided.
        - Click **OK** to restore the database.
     2. **Run SQL Scripts Manually:**
        - Open SSMS and create a new database.
        - Open the provided SQL script files and execute them in SSMS.

3. **Run the Application**

   - Double-click on `BillWiz.exe` to launch the application.
   - Log in using the default credentials (if provided) or create a new user.

## Usage Guide

- Add new products to inventory.
- Generate bills and invoices for customers.
- Track stock levels and sales reports.
- Update and manage customer and supplier details.

## Troubleshooting

- If the application does not open, ensure all dependencies are installed.
- If the database does not connect, verify the SQL Server instance and authentication details.

## License

This project is licensed under [Your License Here].

## Contact

For any issues or support, please contact: **[adityavaibhavpawar@gmail.com](mailto\:adityavaibhavpawar@gmail.com)**

