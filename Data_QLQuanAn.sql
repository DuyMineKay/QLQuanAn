CREATE DATABASE QLQuanAn
GO

USE QLQuanAn
GO

--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	--trống || có người		
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'NV',
	Password NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 --1: admin || 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa dặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL

	FOREIGN KEY	 (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATETIME NOT NULL,
	DateCheckOut DATETIME,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, --1: đã thanh toán || 0 chưa thanh toán
	discount INT

	FOREIGN KEY	 (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT INTO dbo.Account
(
    UserName,
    DisplayName,
    Password,
    Type
)
VALUES
(   N'DMK',     -- UserName - nvarchar(100)
    N'Duy',     -- DisplayName - nvarchar(100)
    N'1', -- Password - nvarchar(1000)
    1  -- Type - int
    )
INSERT INTO dbo.Account
(
    UserName,
    DisplayName,
    Password,
    Type
)
VALUES
(   N'staff',     -- UserName - nvarchar(100)
    N'staff',     -- DisplayName - nvarchar(100)
    N'1', -- Password - nvarchar(1000)
    0  -- Type - int
)
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO
--EXEC dbo.USP_GetAccountByUserName @userName = N'DMK'
--GO

CREATE PROC USP_Login
@userName NVARCHAR(100), @passWord NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND Password = @passWord
END
GO

--------------------------------------------------------------------------------------------------
--Thêm bàn 
/*
DECLARE @i INT = 0
WHILE @i <= 20
BEGIN
    INSERT dbo.TableFood ( name) VALUES (N'Bàn ' +CAST(@i+1 AS NVARCHAR(100))) -- cast: ép kiểu
	SET @i = @i + 1
END
GO
*/

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO
--EXEC dbo.USP_GetTableList

--------------------------------------------------------------------------------------------------
--thêm Category
INSERT INTO dbo.FoodCategory (name) VALUES (N'Hải sản')
INSERT INTO dbo.FoodCategory (name) VALUES (N'Rau củ quả')
INSERT INTO dbo.FoodCategory (name) VALUES (N'Thịt')
INSERT INTO dbo.FoodCategory (name) VALUES (N'Nước')

--------------------------------------------------------------------------------------------------
--thêm Thức ăn
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Sụn gà chiên nước mắm', 3,50000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Nghêu hấp xả',1,50000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Vú heo nướng',3,75000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Cơm chiên tỏi',2,25000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Cơm chiên hải sản',1,50000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Cafe đen',4,18000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Cafe sữa',4,21000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Cam ép',4,25000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Sinh tố bơ',4,30000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Sinh tố xoài',4,30000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Weakup 247',4,12000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'Trà xanh 0 độ',4,12000)
INSERT INTO dbo.Food
	(name, idCategory, price)
VALUES
	(N'7UP',4,12000)


--------------------------------------------------------------------------------------------------
--Thêm Bill
INSERT INTO dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   GETDATE(), -- DateCheckIn - date
    NULL,      -- DateCheckOut - date
    1,         -- idTable - int
    0    -- status - int
    )
INSERT INTO dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   GETDATE(), -- DateCheckIn - date
    NULL,      -- DateCheckOut - date
    2,         -- idTable - int
    0    -- status - int
    )
INSERT INTO dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   GETDATE(), -- DateCheckIn - date
    GETDATE(),      -- DateCheckOut - date
    3,         -- idTable - int
    1    -- status - int
    )

--------------------------------------------------------------------------------------------------
--Thêm BillInfo
INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   1,      -- idBill - int
    1,      -- idFood - int
    2 -- count - int
    )
INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   1,      -- idBill - int
    3,      -- idFood - int
    3 -- count - int
    )
INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   2,      -- idBill - int
    5,      -- idFood - int
    2 -- count - int
    )
GO

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill
	(
	    DateCheckIn,
	    DateCheckOut,
	    idTable,
	    status,
		discount
	)
	VALUES
	(   GETDATE(), -- DateCheckIn - date
	    NULL,      -- DateCheckOut - date
	    @idTable,         -- idTable - int
	    0,    -- status - int
		0
	    )    
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitBillInfo INT;
	DECLARE @foodCount INT = 1;

	SELECT @isExitBillInfo = id, @foodCount = bi.count
	FROM dbo.BillInfo AS bi
	WHERE bi.idBill = @idBill AND idFood = @idFood
	
	IF @isExitBillInfo > 0
		BEGIN
			DECLARE	@newcount INT = @foodCount + @count
			IF (@newcount > 0)
				UPDATE dbo.BillInfo SET count = @foodCount + @count WHERE  idBill = @idBill AND  idFood = @idFood
			ELSE 
				DELETE FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
		END
	ELSE
		BEGIN
			INSERT dbo.BillInfo (idBill,idFood,count)
			VALUES(@idBill, @idFood,@count)
		END
	END
GO

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0

	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill

	IF (@count > 0)
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
	ELSE
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable

END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

CREATE PROC USP_SwitchTable
@idTable1 INT, @idTable2 INT
AS
BEGIN
	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT

	DECLARE @isFisrtTableEmty INT = 1
	DECLARE @isSecondTableEmty INT = 1

	SELECT @idSecondBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0

	IF (@idFirstBill IS NULL)
	BEGIN
	    INSERT INTO dbo.Bill
	    (
	        DateCheckIn,
	        DateCheckOut,
	        idTable,
	        status,
	        discount
	    )
	    VALUES
	    (   GETDATE(),    -- DateCheckIn - datetime
	        NULL,    -- DateCheckOut - datetime
	        @idTable1,       -- idTable - int
	        0, -- status - int
	        0     -- discount - int
	        )
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0

		
	END

	SELECT @isFisrtTableEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill

	IF (@idSecondBill IS NULL)
	BEGIN
	    INSERT INTO dbo.Bill
	    (
	        DateCheckIn,
	        DateCheckOut,
	        idTable,
	        status
	    )
	    VALUES
	    (   GETDATE(),    -- DateCheckIn - datetime
	        NULL,    -- DateCheckOut - datetime
	        @idTable2,       -- idTable - int
	        0 -- status - int
	        )
		SELECT @idSecondBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0

	END

	SELECT @isSecondTableEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSecondBill

    SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSecondBill

	UPDATE dbo.BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill

	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM dbo.IDBillInfoTable)

	DROP TABLE dbo.IDBillInfoTable

	IF (@isFisrtTableEmty = 0)
		UPDATE dbo.TableFood SET status =N'Trống' WHERE id = @idTable2
	IF (@isSecondTableEmty = 0)
		UPDATE dbo.TableFood SET status =N'Trống' WHERE id = @idTable1

END
GO

ALTER TABLE dbo.Bill ADD totalPrice FLOAT

CREATE PROC USP_GetListBillByDay
@checkin DATETIME, @checkout DATETIME
AS
BEGIN
    SELECT t.name AS [Tên bàn],b.totalPrice AS [Tổng tiền] ,DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày thanh toán], discount AS [Giảm giá]
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckIn >= @checkin AND DateCheckOut <= @checkout AND b.status = 1 
		AND t.id = b.idTable
END
GO

CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO

CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
    DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

    DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0

	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO


-- 1 page 2 dòng
-- pageCount = 2
-- pageNum = 2
--lấy 6 dòng đầu ngoại trừ 2 dòng đầu => 4 dòng giữa
--SELECT TOP 6 * FROM dbo.Bill
--EXCEPT
--SELECT TOP 2 * FROM dbo.Bill

CREATE PROC USP_GetListBillByDayAndPage
@checkin DATETIME, @checkout DATETIME, @page int
AS
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows

    ;WITH BillShow AS (SELECT b.id, t.name AS [Tên bàn],b.totalPrice AS [Tổng tiền] ,DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày thanh toán], discount AS [Giảm giá]
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckIn >= @checkin AND DateCheckOut <= @checkout AND b.status = 1 
		AND t.id = b.idTable)

	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END
GO

CREATE PROC USP_GetNumBillByDay
@checkin DATETIME, @checkout DATETIME
AS
BEGIN
	SELECT COUNT(*)	
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckIn >= @checkin AND DateCheckOut <= @checkout AND b.status = 1 
		AND t.id = b.idTable
END
GO
