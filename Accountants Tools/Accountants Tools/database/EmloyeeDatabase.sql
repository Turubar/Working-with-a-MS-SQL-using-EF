CREATE DATABASE EmployeeDatabase
GO

USE EmployeeDatabase
GO

CREATE TABLE Employee (
id BIGINT PRIMARY KEY IDENTITY NOT NULL,
last_name NVARCHAR(100) NOT NULL,
first_name NVARCHAR(100) NOT NULL,
middle_name NVARCHAR(100) NOT NULL,
gender NVARCHAR(7) NOT NULL CHECK (gender IN('Мужчина', 'Женщина')),
details_passport NVARCHAR(11) NOT NULL UNIQUE,
date_of_birth DATE NOT NULL,
country_of_birth NVARCHAR(100) NOT NULL,
residency NVARCHAR(150) DEFAULT ('Not defined'),
number_phone NVARCHAR(12) DEFAULT ('Not defined') UNIQUE,
email NVARCHAR(100) DEFAULT ('Not defined') UNIQUE)
GO

CREATE TABLE Company (
id BIGINT PRIMARY KEY IDENTITY NOT NULL,
company_name NVARCHAR(100) NOT NULL UNIQUE,
last_name_owner NVARCHAR(100) NOT NULL,
first_name_owner NVARCHAR(100) NOT NULL,
middle_name_owner NVARCHAR(100) NOT NULL,
date_of_creation DATE NOT NULL,
company_description NVARCHAR(MAX) DEFAULT ('Not defined'))
GO

CREATE TABLE Company_positions1 (
id BIGINT PRIMARY KEY IDENTITY NOT NULL,
name_position NVARCHAR(100) NOT NULL,
salary_for_position DECIMAL(10, 2) NOT NULL,
description_position NVARCHAR(MAX) NOT NULL,
id_company BIGINT NOT NULL, FOREIGN KEY (id_company) REFERENCES Company (id))
GO

CREATE TABLE Employment_contracts (
id BIGINT PRIMARY KEY IDENTITY NOT NULL,
date_of_conclusion DATE NOT NULL,
id_employee BIGINT NOT NULL, FOREIGN KEY (id_employee) REFERENCES Employee (id),
id_position BIGINT NOT NULL, FOREIGN KEY (id_position) REFERENCES Company_positions (id))
GO

