CREATE PROC [dbo].[prCalisanGetir] (@calisanNo INT)
AS 
	SELECT * FROM Calisanlar WHERE CalisanNo = @calisanNo
GO

------------------------------------------------------------

CREATE PROC [dbo].[prCalisanGirisiniDogrula] (@eposta NVARCHAR(50), @sifre NVARCHAR(10))
AS
	SELECT CalisanNo FROM Calisanlar WHERE EPosta = @eposta AND Sifre = @sifre
GO

------------------------------------------------------------

CREATE PROC [dbo].[prCalisanGuncelle]
(
	@calisanNo INT,
	@tcKimlikNo NCHAR(11),
	@ad NVARCHAR(50),
	@soyad NVARCHAR(50),
	@unvan NVARCHAR(50),
	@eposta NVARCHAR(50),
	@telefonNo NVARCHAR(50),
	@sifre NVARCHAR(10),
	@calisanTipi SMALLINT
)
AS
	UPDATE Calisanlar 
	SET 
		[TCKimlikNo] = @tCKimlikNo, 
		[Ad] = @ad, 
		[Soyad] = @soyad, 
		[Unvan] = @unvan, 
		[EPosta] = @ePosta, 
		[TelefonNo] = @telefonNo, 
		[Sifre] = @sifre, 
		[CalisanTipi] = @calisanTipi
	WHERE CalisanNo = @calisanNo
GO

------------------------------------------------------------

CREATE  PROC [dbo].[prCalisanlariListele]
(
	@ad NVARCHAR(50),
	@soyad NVARCHAR(50)
)
AS
	SELECT * FROM Calisanlar WHERE Ad LIKE @ad + '%' AND Soyad LIKE @soyad + '%'
GO

------------------------------------------------------------

CREATE PROC [dbo].[prCalisanSifreDegistir] (@calisanNo INT, @sifre NVARCHAR(10))
AS
	UPDATE Calisanlar SET Sifre = @sifre WHERE CalisanNo = @calisanNo
GO

------------------------------------------------------------

CREATE PROC [dbo].[prCalisanSifreSifirla] (@eposta NVARCHAR(50), @sifre NVARCHAR(10))
AS
	UPDATE Calisanlar SET Sifre = @sifre WHERE EPosta = @eposta
GO

------------------------------------------------------------

CREATE PROC [dbo].[prCalisanUzmanlariListele]
AS
	SELECT * FROM Calisanlar WHERE CalisanTipi = 2 -- Uzman
GO

------------------------------------------------------------

CREATE PROC [dbo].[prCalisanYeniKaydet]
(
	@tcKimlikNo NCHAR(11),
	@ad NVARCHAR(50),
	@soyad NVARCHAR(50),
	@unvan NVARCHAR(50),
	@eposta NVARCHAR(50),
	@telefonNo NVARCHAR(50),
	@sifre NVARCHAR(10),
	@calisanTipi SMALLINT,
	@calisanNo INT OUT
)
AS
	INSERT INTO Calisanlar
		([TCKimlikNo], [Ad], [Soyad], [Unvan], [EPosta], [TelefonNo], [Sifre], [CalisanTipi]) 
	VALUES
		(@tcKimlikNo, @ad, @soyad, @unvan, @eposta, @telefonNo, @sifre, @calisanTipi)
	SELECT @calisanNo = @@IDENTITY
GO

------------------------------------------------------------

CREATE PROC [dbo].[prHastaGetir] (@hastaNo INT)
AS 
	SELECT * FROM Hastalar WHERE HastaNo = @hastaNo
GO

------------------------------------------------------------

CREATE PROC [dbo].[prHastaGuncelle]
(
	@hastaNo INT,
	@tcKimlikNo NCHAR(11),
	@ad NVARCHAR(50),
	@soyad NVARCHAR(50),
	@dogumTarihi DATETIME,
	@cinsiyet CHAR(1),
	@eposta NVARCHAR(50),
	@telefonNo NVARCHAR(50),
	@adres NVARCHAR(MAX)
)
AS
	UPDATE Hastalar 
	SET 
		[TCKimlikNo] = @tCKimlikNo, 
		[Ad] = @ad, 
		[Soyad] = @soyad, 
		[Cinsiyet] = @cinsiyet, 
		[EPosta] = @ePosta, 
		[TelefonNo] = @telefonNo, 
		[Adres] = @adres, 
		[DogumTarihi] = @dogumTarihi
	WHERE HastaNo = @hastaNo
GO

------------------------------------------------------------

CREATE PROC [dbo].[prHastalariListele]
(
	@ad NVARCHAR(50),
	@soyad NVARCHAR(50)
)
AS
	SELECT * FROM Hastalar WHERE Ad LIKE @ad + '%' AND Soyad LIKE @soyad + '%'
GO

------------------------------------------------------------

CREATE PROC [dbo].[prHastaYeniKaydet]
(
	@tcKimlikNo NCHAR(11),
	@ad NVARCHAR(50),
	@soyad NVARCHAR(50),
	@dogumTarihi DATETIME,
	@cinsiyet CHAR(1),
	@eposta NVARCHAR(50),
	@telefonNo NVARCHAR(50),
	@adres NVARCHAR(MAX),
	@hastaNo INT OUT
)
AS
	INSERT INTO Hastalar
		([TCKimlikNo], [Ad], [Soyad], [DogumTarihi], [EPosta], [TelefonNo], [Cinsiyet], [Adres]) 
	VALUES
		(@tcKimlikNo, @ad, @soyad, @dogumTarihi, @eposta, @telefonNo, @cinsiyet, @adres)
	SELECT @hastaNo = @@IDENTITY

GO

------------------------------------------------------------

CREATE PROC [dbo].[prSeansCakisanSeansSayisi]
(
	@uzmanNo INT,
	@tarih DATETIME,
	@baslangicSaati CHAR(5),
	@bitisSaati CHAR(5)
)
AS
	SELECT COUNT(SeansNo) FROM Seanslar WHERE UzmanNo = @uzmanNo 
											  AND Tarih = @tarih 
											  AND (
													@baslangicSaati >= BaslangicSaati AND @baslangicSaati <= BitisSaati
													OR 
													@bitisSaati >= BaslangicSaati AND @bitisSaati <= BitisSaati
												  )
GO

------------------------------------------------------------

CREATE PROC [dbo].[prSeansHastaSeanslariniListele] (@hastaNo INT)
AS
	SELECT SNS.*, 
		   ISNULL(HST.Ad + ' ' + HST.Soyad, '') HastaBilgisi,
		   UZM.Ad + ' ' + UZM.Soyad UzmanBilgisi
	FROM Seanslar SNS
	INNER JOIN Calisanlar UZM ON SNS.UzmanNo = UZM.CalisanNo
	LEFT JOIN Hastalar HST ON SNS.HastaNo = HST.HastaNo
	WHERE SNS.HastaNo = @hastaNo AND IptalEdenNo IS NULL
	ORDER BY Tarih DESC, BaslangicSaati DESC
GO

------------------------------------------------------------

CREATE PROC [dbo].[prSeansHastaSonRandevuBilgisiGetir] (@hastaNo INT)
AS
	SELECT TOP 1 SNS.*, 
				 ISNULL(HST.Ad + ' ' + HST.Soyad, '') HastaBilgisi,
				 UZM.Ad + ' ' + UZM.Soyad UzmanBilgisi
		FROM Seanslar SNS
	INNER JOIN Calisanlar UZM ON SNS.UzmanNo = UZM.CalisanNo
	LEFT JOIN Hastalar HST ON SNS.HastaNo = HST.HastaNo
	WHERE SNS.HastaNo = @hastaNo AND IptalEdenNo IS NULL
	ORDER BY Tarih DESC
GO

------------------------------------------------------------

CREATE PROC [dbo].[prSeansHastaSonSeansBilgisiGetir] (@hastaNo INT)
AS
	SELECT TOP 1 SNS.*, 
				 ISNULL(HST.Ad + ' ' + HST.Soyad, '') HastaBilgisi,
				 UZM.Ad + ' ' + UZM.Soyad UzmanBilgisi
		FROM Seanslar SNS
	INNER JOIN Calisanlar UZM ON SNS.UzmanNo = UZM.CalisanNo
	LEFT JOIN Hastalar HST ON SNS.HastaNo = HST.HastaNo
	WHERE SNS.HastaNo = @hastaNo AND SeansYapildi = 1
	ORDER BY Tarih DESC
GO

------------------------------------------------------------

CREATE PROC [dbo].[prSeansIptalEt] 
(
	@seansNo INT,
	@iptalEdenNo INT,
	@iptalNotu NVARCHAR(MAX),
	@hastaIptalEtti BIT
)
AS
	UPDATE Seanslar 
		SET 
			IptalEdenNo = @iptalEdenNo,
			IptalNotu = @iptalNotu,
			HastaIptalEtti = @hastaIptalEtti
		WHERE SeansNo = @seansNo
GO

------------------------------------------------------------

CREATE PROC [dbo].[prSeansNotuGuncelle] (@seansNo INT, @seansNotu NVARCHAR(MAX))
AS
	UPDATE Seanslar SET SeansNotu = @seansNotu, SeansYapildi = 1 WHERE SeansNo = @seansNo
GO

------------------------------------------------------------

CREATE PROC [dbo].[prSeansRandevuIptalEt] (@seansNo INT)
AS
	UPDATE Seanslar SET HastaNo = NULL WHERE SeansNo = @seansNo
GO

------------------------------------------------------------

CREATE PROC [dbo].[prSeansRandevuKaydet] (@seansNo INT, @hastaNo INT)
AS
	UPDATE Seanslar SET HastaNo = @hastaNo WHERE SeansNo = @seansNo
GO

------------------------------------------------------------

CREATE PROC [dbo].[prSeansUzmanSeanslariniListele] (@uzmanNo INT)
AS
	SELECT SNS.*, 
				 ISNULL(HST.Ad + ' ' + HST.Soyad, '') HastaBilgisi,
				 UZM.Ad + ' ' + UZM.Soyad UzmanBilgisi
		FROM Seanslar SNS
	INNER JOIN Calisanlar UZM ON SNS.UzmanNo = UZM.CalisanNo
	LEFT JOIN Hastalar HST ON SNS.HastaNo = HST.HastaNo
	WHERE UzmanNo = @uzmanNo AND IptalEdenNo IS NULL
	ORDER BY Tarih DESC, BaslangicSaati DESC
GO

------------------------------------------------------------

CREATE PROC [dbo].[prSeansYeniKaydet]
(
	@uzmanNo INT,
	@tarih DATETIME,
	@baslangicSaati CHAR(5),
	@bitisSaati CHAR(5),
	@seansNo INT OUT
)
AS
	INSERT INTO Seanslar
		([UzmanNo], [Tarih], [BaslangicSaati], [BitisSaati]) 
	VALUES
		(@uzmanNo, @tarih, @baslangicSaati, @bitisSaati)
	SELECT @seansNo = @@IDENTITY
GO
