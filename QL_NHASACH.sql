CREATE DATABASE QL_NHASACH
use QL_NHASACH

create table QUANLY
(
	tkquanly char(30) primary key,
	matkhau char(30),
	hotenquanly nvarchar(50),
	gioitinh nvarchar(3),
	ngaysinh date,
)

create table NHANVIEN
(
	tknhanvien char(30) primary key,
	matkhau char(30),
	hotennhanvien nvarchar(50),
	gioitinh nvarchar(3),
	ngaysinh date,
	diachi nvarchar(100),
)

create table CHUDE
(
	macd int identity(1,1) primary key,
	tencd nvarchar(50),
)

create table NHAXUATBAN
(
	manxb int identity(1,1) primary key,
	tennxb nvarchar(50),
	diachi nvarchar(100),
	sdt char(12),
)

create table TACGIA
(
	matg int identity(1,1) primary key,
	tentg nvarchar(50),
)

create table SACH
(
	masach int primary key,
	tensach nvarchar(50),
	gia int,
	soluong tinyint,
	mota nvarchar(max),
	macd int,
	manxb int,
	matg int,
)

create table HOADON
(
	mahd int   primary key,
	nguoiban char(30),
	khachmua char(12),
	ngaymua char(50),
	tongtien int,
)

alter table QUANLY
add constraint chk_gt check (gioitinh=N'Nam' or gioitinh=N'Nữ')

alter table NHANVIEN
add constraint chk_gt2 check (gioitinh=N'Nam' or gioitinh=N'Nữ')

alter table SACH
add constraint fk_1 foreign key(macd) references CHUDE(macd)

alter table SACH
add constraint fk_2 foreign key(manxb) references NHAXUATBAN(manxb)

alter table SACH
add constraint fk_3 foreign key(matg) references TACGIA(matg)

set dateformat dmy
insert into QUANLY values
('minhnguyen1812', '181200', N'Nguyễn Hoàng Minh', N'Nam', '18/12/2000'),
('baole1010', '101000', N'Lê Quốc Bảo', N'Nam', '10/10/2000')

insert into CHUDE values
( N'Văn học'),
( N'Huyền bí giả tưởng'),
(  N'Kinh điển'),
( N'Trinh thám'),
( N'Tản văn'),
( N'Tiểu sử'),
( N'Âm nhạc'),
( N'Tâm linh'),
( N'Khoa học'),
( N'Kỹ năng làm việc'),
( N'Tài chính'),
( N'Du ký')

insert into NHAXUATBAN values
(N'NXB Kim Đồng', N'55 Quang Trung, Hai Bà Trưng, Hà Nội', '02439434730'),
(N'NXB Trẻ', N'161B Lý Chính Thắng, Phường 7, Quận 3, Thành phố Hồ Chí Minh', '39316289'),
(N'NXB Tổng hợp TpHCM', N'62 Nguyễn Thị Minh Khai, Phường Đa Kao, Quận 1, TP.HCM', '38225340'),
(N'NXB Chính trị quốc gia sự thật', N'6/86 Duy Tân, Cầu Giấy, Hà Nội', '028049221'),
(N'NXB Giáo dục', N'81 Trần Hưng Đạo, Hà Nội', '02438220801'),
(N'NXB Hội nhà văn', N'65 Nguyễn Du, Hà Nội', '02438222135'),
(N'NXB Tư pháp', N'35 Trần Quốc Toản, Hoàn Kiếm, Hà Nội', N'02462632078'),
(N'NXB Thông tin và Truyền thông', N'Tầng 6, Tòa nhà Cục Tần số Vô tuyến điện, số 115 Trần Duy Hưng, Hà Nội', '02435772145'),
(N'NXB Lao động', N'175 Giảng Võ, Đống Đa, Hà Nội', '02438515380'),
(N'NXB Giao thông vận tải', N'80B Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', '02439423346'),
(N'NXB ĐH quốc gia Hà Nội', N'16 Hàng Chuối, Phạm Đình Hổ, Hai Bà Trưng, Hà Nội', '02439714896')

insert into TACGIA values
( N'Ernest Miller Hemingway'),
(N'John Ronald Reuel Tolkien'),
( N'Victor Hugo'),
(N'Arthur Conan Doyle'),
(N'Miêu Công Tử'),
(N'Hermann Hesse'),
(N'Benjamin Graham'),
(N'Jack Kerouac')

insert into HOADON values 
(1,'baole1010','070345662','01/01/2020',20000)
