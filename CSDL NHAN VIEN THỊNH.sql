
CREATE DATABASE QLNHANVIEN4
GO
USE QLNHANVIEN4
GO
CREATE TABLE PHONGBAN(
MaPB NVARCHAR(50) PRIMARY KEY Not Null,
TenPB NVARCHAR(50),
)
CREATE TABLE DANGNHAP(
MaNV nvarchar(50),
TenDN nvarchar(50),
MK nvarchar(50),
ChucVu nvarchar(50),
CONSTRAINT DANGNHAP_NHANVIEN_FK FOREIGN KEY( MaNV) REFERENCES NHANVIEN(MaNV),

)
GO
CREATE TABLE NHANVIEN(
MaNV nvarchar(50) PRIMARY KEY Not Null,
MaPB nvarchar(50) Not Null,
MaCN nvarchar(50) Not Null,
MaCV nvarchar(50) Not Null,
MaHD nvarchar(50) Not Null,
HoTen Nvarchar(50) ,
NgaySinh nvarchar(50),
GioiTinh nvarchar(50),
QueQuan Nvarchar(50),
SDT nvarchar(50),
CONSTRAINT NV_CN_FK FOREIGN KEY(MaCN)REFERENCES CHINHANH(MaCN),
CONSTRAINT NV_PB_FK FOREIGN KEY(MaPB) REFERENCES PHONGBAN(MaPB),
CONSTRAINT NV_CV_FK FOREIGN KEY(MaCV) REFERENCES CHUCVU(MaCV),
CONSTRAINT NV_HD_FK FOREIGN KEY(MaHD) REFERENCES HDLD(MaHD),
)
GO
CREATE TABLE CHINHANH(
MaCN nvarchar(50) Primary key Not Null,
TenCN nvarchar(50) 
)


CREATE TABLE CHUCVU(
MaCV nvarchar(50) Primary key Not Null,
TenCV nvarchar(50) ,
PhuCap money ,
)
GO
CREATE TABLE LUONG(
MaNV nvarchar(50),
HeSoLuong nvarchar(50),
LuongCB nvarchar(50),
CONSTRAINT NV_LUONG_FK FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV),
)
GO
CREATE TABLE HDLD(
MaHD nvarchar(50) primary key,
TenHD nvarchar(50),
LoaiHD nvarchar(50),
)

GO
set dateformat dmy;
insert into CHINHANH(MaCN,TenCN) values ('CN1',N'Đà Lạt')
insert into CHINHANH(MaCN,TenCN) values ('CN2',N'TPHCM')

INSERT INTO PHONGBAN
        ( MaPB,TenPB)
VALUES  ('PB1',N'Phòng ban 1'),
('PB2',N'Phòng ban 2'),
('PB3',N'Phòng ban 3')
GO
INSERT INTO NHANVIEN
        ( MaNV ,MaPB,MaCN,MaCV,MaHD,
          HoTen ,
          GioiTinh ,
          QueQuan ,
          NgaySinh ,
          SDT
        )
VALUES  ('NV01','PB1','CN1','BA','HD1',N'Nguyễn Trọng Liêm','Nam','Daklak','05/05/1997','0935447462'),
('NV02','PB2','CN1','GDSX','HD2',N'Trần Phương Bình','Nam','TPHCM','03/06/1998','0935423732'),
('NV03','PB1','CN2','SA','HD1',N'Nguyễn Duy Khang',N'Nữ','Daklak','15/04/1997','093557462'),
('NV04','PB3','CN1','NVKT','HD2',N'Nguyễn Thành Tuấn','Nam','TPHCM','16/05/1999','0935597462'),
('NV05','PB1','CN1','DDBH','HD1',N'Nguyễn Thanh Phương',N'Nữ',N'Quy Nhơn','17/02/1998','0936847462'),
('NV06','PB2','CN2','BA','HD2',N'Nguyễn Hoàng Nam','Nam',N'Cà Mau','14/08/1997','0935478462'),
('NV07','PB3','CN1','SA','HD1',N'Nguyễn Thị Nở',N'Nữ','TPHCM','18/09/1998','0935468462'),
('NV08','PB3','CN2','BA','HD2',N'Nguyễn Phương Khoa','Nam',N'Rạch Giá','28/05/1999','0935894462')
GO

INSERT INTO DANGNHAP 
( MaNV, TenDN, MK, ChucVu)
VALUES ( N'NV01','NV1','123',N'Quản lý'),
       ( N'NV02','NV2','123',N'Nhân viên'),
       ( N'NV03','NV3','123',N'Quản lý'),
       ( N'NV04','NV4','123',N'Nhân viên'),
       ( N'NV05','NV5','123',N'Nhân viên'),
	   ( N'NV06','NV6','123',N'Nhân viên'),
	   ( N'NV07','NV7','123',N'Nhân viên'),
	   ( N'NV08','NV8','123',N'Nhân viên')
GO
INSERT INTO CHUCVU
(MaCV, TenCV, Phucap)
VALUES ('GDSX', N'Giám đốc sản xuất', '5000000'),
       ('BA', N'Bussiness analyst', '5000000'),
       ('SA', N'Systems analyst', '5000000'),
       ('NVKT', N'Nhân viên kế toán', '3000000'),
       ('DDBH', N'Đại diện bán hàng', '2000000')
GO



INSERT INTO LUONG
(MaNV, HeSoLuong ,LuongCB)
VALUES ('NV01', '1', 3000000),
       ('NV02', '2', 400000),
       ('NV03', '3', 5500000),
       ('NV04', '4', 6000000),
       ('NV05', '5', 7000000),
	   ('NV06', '1', 4000000),
	   ('NV07', '2',50000000),
	   ('NV08', '3',5069969)
GO

INSERT INTO HDLD
(MaHD, TenHD, LoaiHD)
VALUES ('HD1', N'Hợp đồng xác định thời hạn ',N'Ngắn hạn' ),
       ('HD2', N'Hợp đồng không xác định thời hạn ',N'Dài hạn' )
   
GO

drop database QLNHANVIEN


select * from link1.QLNHANVIEN4.dbo.CHINHANH

