### Buổi 8:
* Chủ đề: oop - polymorphism, interface
#### Bài tập:
1. Static polymorphism hay method overloading: nâng cấp static class Calculator với nhiều phiên bản của các phương thức trong nó. Ví dụ, Add(3, 3) nhận 2 số dạng int còn Add(10.05, 11.33) nhận 2 số double,...

2. Dynamic polymorphism hay method overriding: sử dụng abstract hay virtual method ở lớp cha và lớp con override - tạo base class là Shape và lớp con Circle, Rectangle,...có phương thức getArea, getPerimeter,...Mỗi lớp có thuộc tính phù hợp và cách thực thi phương thức getArea, getPerimeter khác nhau.

3. Tạo nhiều class và thực thi interface chung theo ví dụ trong videos: class smartphone có lớp con IPhone, Samsung sẽ thực thi 1 interface nào đó. Chi tiết các phương thức và interface các bạn tự dựng.
4. Product Inventory: tạo ưng dụng quản lý sản phẩm, lớp Product gồm thông tin tên, số lượng, giá,...; lớp Inventory quản lý nhiều sản phẩm, thay đổi sản phẩm, thể hiện giá trị thông tin sản phẩm,....Khi khởi tạo lớp Product ta tạo 1 loại sản phẩm, ví dụ, apple. Nhưng khi khởi tạo 1 Inventory, nó có thể chứa nhiều loại sản phẩm, ví dụ `inventory1.Items = new List<Product>(){apple, banana, watermelon};`. Tự nghĩ phần xử lý logic của các phương thức hợp lý. Ví dụ, AddProduct() thêm sản phẩm vào trong 1 inventory. Lớp Inventory quản lý có phương thức IncreaseQuantity(apple, 2) thì tăng số lượng của apple 2 đơn vị, tương tự các phương thức DecreaseQuantity(), IncreasePrice(),...Phần thực thi của các phương thức nên kiểm tra xem sản phẩm có tồn tại hay không, nếu không tồn tại thì yêu cầu gọi AddProduct() để thêm vào trước.

5. Bank Account Manager: Account base class với derived classes: SavingAccount, CheckingAccount, InvestmentAccount. Các bạn tự thiết kế thuộc tính, phương thức hợp lý theo ý mình.
