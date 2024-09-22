USE Okul

CREATE TABLE Bolumler (
    BolumID INT PRIMARY KEY IDENTITY(1,1),
    BolumAdi NVARCHAR(50) NOT NULL
)
--alt shft a // ctrl k c // ctrl ö

CREATE TABLE  Dersler(
    DersID INT PRIMARY KEY IDENTITY(1,1),
    DersAdi NVARCHAR(100) NOT NULL,
    Kredi TINYINT NOT NULL,
    BolumID INT NOT NULL,
    FOREIGN KEY(BolumID) REFERENCES  Bolumler(BolumID)
)

CREATE TABLE Ogrenciler(
    OgrenciID INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    DogumTarihi DATE NULL,
    BolumID INT NOT NULL ,
    FOREIGN KEY(BolumID) REFERENCES Bolumler(BolumID),
)

CREATE TABLE DersKayitlari(
    OgrenciID INT ,
    DersID INT,
    PRIMARY KEY(OgrenciID,DersID),--İKİSİNİ BİRDEN PRİMERİ KEY YAPTIM Kİ AYNI ÖĞRENCİYE AYNI DERSİ GİREMEYELİM 
    FOREIGN KEY(OgrenciID) REFERENCES Ogrenciler(OgrenciID),
    FOREIGN KEY(DersID) REFERENCES Dersler(DersID)
)