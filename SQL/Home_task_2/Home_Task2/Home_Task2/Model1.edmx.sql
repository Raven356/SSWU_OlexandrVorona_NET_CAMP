
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/08/2023 16:24:03
-- Generated from EDMX file: D:\C#\Net_Camp\SQL\Home_task_2\Home_Task2\Home_Task2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [UniversityLibrary];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BooksSet'
CREATE TABLE [dbo].[BooksSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [YearOfCreation] datetime  NOT NULL,
    [Amount] int  NOT NULL,
    [PublisherId] int  NOT NULL,
    [GenreId] int  NOT NULL
);
GO

-- Creating table 'PublisherSet'
CREATE TABLE [dbo].[PublisherSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [ContactPhone] nvarchar(30)  NOT NULL,
    [ContactMail] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'GenreSet'
CREATE TABLE [dbo].[GenreSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BooksSet'
ALTER TABLE [dbo].[BooksSet]
ADD CONSTRAINT [PK_BooksSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PublisherSet'
ALTER TABLE [dbo].[PublisherSet]
ADD CONSTRAINT [PK_PublisherSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GenreSet'
ALTER TABLE [dbo].[GenreSet]
ADD CONSTRAINT [PK_GenreSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PublisherId] in table 'BooksSet'
ALTER TABLE [dbo].[BooksSet]
ADD CONSTRAINT [FK_BooksPublisher]
    FOREIGN KEY ([PublisherId])
    REFERENCES [dbo].[PublisherSet]
        ([Id])
    ON DELETE cascade ON UPDATE cascade;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BooksPublisher'
CREATE INDEX [IX_FK_BooksPublisher]
ON [dbo].[BooksSet]
    ([PublisherId]);
GO

-- Creating foreign key on [GenreId] in table 'BooksSet'
ALTER TABLE [dbo].[BooksSet]
ADD CONSTRAINT [FK_BooksGenre]
    FOREIGN KEY ([GenreId])
    REFERENCES [dbo].[GenreSet]
        ([Id])
    ON DELETE cascade ON UPDATE cascade;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BooksGenre'
CREATE INDEX [IX_FK_BooksGenre]
ON [dbo].[BooksSet]
    ([GenreId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------