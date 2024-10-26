USE master
GO

IF DB_ID('PortfolioDb') IS NOT NULL
BEGIN
    ALTER DATABASE PortfolioDb  SET single_user WITH ROLLBACK IMMEDIATE
    DROP DATABASE PortfolioDb
END
GO

CREATE DATABASE PortfolioDb COLLATE Turkish_CI_AS
GO

USE PortfolioDb
GO

CREATE TABLE AppSetting
(
    Id INT PRIMARY KEY IDENTITY,
    BrandName NVARCHAR(100) not NULL,
    HeroTitle NVARCHAR(200) not null,
    HeroSubTitle NVARCHAR(300) not null,
    HeroImageUrl NVARCHAR(2000) not null,
    AboutText NVARCHAR(4000) not null,
    AboutImageUrl NVARCHAR(2000) not null,
    SkillsImageUrl NVARCHAR(2000) not null,
    AddressText NVARCHAR(500) NOT NULL,
    AddressDistrict NVARCHAR(100) NOT NULL,
    AddressCity NVARCHAR(100) NOT NULL,
    PhonenNumber NVARCHAR(20) NOT NULL,
    Email NVARCHAR(200) NOT NULL,
    GoogleMap NVARCHAR(1000) NOT NULL,
    CreadetDate DATETIME not NULL DEFAULT getdate(),
    ModifiedDate DATETIME
)
GO

INSERT INTO AppSetting
    (BrandName,HeroTitle,HeroSubTitle,HeroImageUrl,AboutText,AboutImageUrl,SkillsImageUrl,AddressText,AddressDistrict,AddressCity,PhonenNumber,Email,GoogleMap,CreadetDate,ModifiedDate)

VALUES
    (
        'Samet Önür',
        'Back-End Developer',
        'DotNet | Asp.Net Core MVC | Asp.Net Core WebAPI',
        'https://Localhost:5100/img/hero-img.png',
        '
    <p>AcunMedya Akademi''de aldığım yazılım eğitimi sırasında ve sonrasında yaptığım alışmalarla kednimi geliştirdim. Hem Frontend hem de backend konularında bilgi ve deneyim sahibi olmama karşın, kendimi backend tarafında geliştiriyorum</p>
        <h4>Eğitim Aldığım Konular</h4>
        <li>Temel C# Programlama</li>
        <li>Object Oriented Programing</li>
        <li>HTML, CSS, JavaScript</li>
        <li>Entity Framwork Core</li> 
        ',
        'https://Localhost:5100/img/about-img.png',
        'https://Localhost:5100/img/skill-img.png',
        'Cemal Reşit Rey yolu, mediun plaza k:4',
        'Kadıköy',
        'İstanbul',
        '90 539 648 61 00',
        'sametonur@gmail.com',
        '"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3005.694521500494!2d29.0073392759042!3d41.1193621713352!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab5b39cefc5e3%3A0xee4f06a4f79630ce!2sAcunmedya%20Akademi!5e0!3m2!1str!2str!4v1729907650699!5m2!1str!2str"'
    )
    GO

CREATE TABLE Socials
(

    Id int PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) not null,
    Url NVARCHAR(50) not null,
    Icon NVARCHAR(50) not null,
    IsActive bit not NULL DEFAULT 1,
    CreadetDate DATETIME not NULL DEFAULT getdate(),
    ModifiedDate DATETIME

)
GO

insert INTO Socials
    (Name, Url, Icon)

VALUES
    (
        'GitHub', 'https://www.Github.com', 'github'
),
    (
        'LinkedIn', 'https://www.linkedin.com', 'linkedin'
),
    (
        'Medium', 'https://www.medium.com', 'medium'
),
    (
        'Instagram', 'https://www.instagram.com', 'instagram'
),
    (
        'X', 'https://www.x.com', 'twitter-x'
)
GO

CREATE TABLE Skills
(

    Id int PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) not null,
    Url NVARCHAR(50) not null,
    Rate TINYINT not NULL,
    IsActive bit not NULL DEFAULT 1,
    CreadetDate DATETIME not NULL DEFAULT getdate(),
    ModifiedDate DATETIME

)
GO

insert INTO Skills
    (Name, Rate)
VALUES
    (
        'Html', 100
 ),
    (
        'Css', 95
),
    (
        'JavaScript', 85
),
    (
        'AspNet Core MVC', 95
)

GO

CREATE TABLE Services
(

    Id int PRIMARY KEY IDENTITY,
    Title NVARCHAR(50) not null,
    Icon NVARCHAR(50) not null,
    Description NVARCHAR(1000) not null,
    IsActive bit not NULL DEFAULT 1,
    CreadetDate DATETIME not NULL DEFAULT getdate(),
    ModifiedDate DATETIME
)
GO

insert INTO Services
    (Title, Description, Icon)

VALUES
    ('SEO Hizmeti', 'Arama Motoru Optimizasyonu', 'activity'),
    ('web Uygulamaları', 'İsteğe göre özel web site uygulamaları geliştirme', 'bounding-box-circles'),
    ('Server Yönetimi', 'Sunucunun oluşturulup bakım ve yönetilmelerini yapılması', 'calendar4-week'),
    ('SPA ', 'Single Page Application Uygulamalarının geliştirilmesi', 'broadcast')
GO

CREATE TABLE Categories
(

    Id int PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) not null,
    Url NVARCHAR(50) not null,
    IsActive bit not NULL DEFAULT 1,
    CreadetDate DATETIME not NULL DEFAULT getdate(),
    ModifiedDate DATETIME
)

GO

insert INTO Categories
    (Name)
VALUES
    ('MVC'),
    ('FrontEnd'),
    ('API')
GO

CREATE TABLE Projects
(
    Id int PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) not null,
    Description NVARCHAR(1000) not null,
    GithubUrl NVARCHAR(1000) not null,
    ImageUrl NVARCHAR(1000) not null,
    IsActive bit not NULL DEFAULT 1,
    CreadetDate DATETIME not NULL DEFAULT getdate(),
    ModifiedDate DATETIME,
    CategoryId INT FOREIGN KEY REFERENCES Categories(Id)

)
GO

INSERT INTO Projects
    (Name, Description, GithubUrl, ImageUrl)
VALUES
    ('Proje 1', 'Proje 1 açıklaması', 'https://www.github.com', 'http://localhost:5100/ui/img/projects/project1.jpg'),
    ('Proje 2', 'Proje 1 açıklaması', 'https://www.github.com', 'http://localhost:5100/ui/img/projects/project2.jpg'),
    ('Proje 3', 'Proje 1 açıklaması', 'https://www.github.com', 'http://localhost:5100/ui/img/projects/project3.jpg'),
    ('Proje 4', 'Proje 1 açıklaması', 'https://www.github.com', 'http://localhost:5100/ui/img/projects/project4.jpg'),
    ('Proje 5', 'Proje 1 açıklaması', 'https://www.github.com', 'http://localhost:5100/ui/img/projects/project5.jpg'),
    ('Proje 6', 'Proje 1 açıklaması', 'https://www.github.com', 'http://localhost:5100/ui/img/projects/project6.jpg'),
    ('Proje 7', 'Proje 1 açıklaması', 'https://www.github.com', 'http://localhost:5100/ui/img/projects/project7.jpg'),
    ('Proje 8', 'Proje 1 açıklaması', 'https://www.github.com', 'http://localhost:5100/ui/img/projects/project8.jpg')
GO









