Tải dự án bằng cách
```bash
git clone https://github.com/wsxyanua/CafeManager.git
```

khởi chạy bằng visual studio 2022
khi chạy nhớ Build trước (Ctrl + Shift + B)

sử dụng file CafeManager2-fix.sql làm database
đổi tên file CafeManager2-fix.sql thành CafeManager2.sql

mở nhanh dự án bằng cách click CafeManager.sln

trong Solution Explorer nhìn file App.config
```bash
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
	<connectionStrings>
		<add name="CafeManager2"
			 connectionString="Data Source= wsxyanua;
			 Initial Catalog=CafeManager2; 
			 TrustServerCertificate=True;
			 Integrated security=True"/>
	</connectionStrings>
</configuration>
```
đoạn 'Data Source= wsxyanua' xóa 'wsxyanua' thay thế tên thiết bị của bạn.

trong database sau khi create table, insert into chạy tiếp cái này:
```bash
--fix tk admin 
UPDATE DangKy SET ChucVu = 0 WHERE TenDK = 'admin';
UPDATE DangKy SET ChucVu = 1 WHERE TenDK <> 'admin';
```
(cái này fix tài khoản admin vì lỗi éo gì ấy mà thằng code cũng không biết :) )
và kết nối database nhé

Anyway, đây là hưỡng dẫn cơ bản để tránh lỗi khi chạy trên thiết bị của các bạn (lười đóng gói)
HẾT RỒI
