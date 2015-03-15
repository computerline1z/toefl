Nhóm ChanhProTK

Các thành viên :
Nguyễn Huệ Nghi
Nguyễn Thị Như Anh
Lê Anh Tài

Hướng dẫn sử dụng :

_Cài đặt TortoiseSVN_

_Link down tại đây :
http://jaist.dl.sourceforge.net/sourceforge/tortoisesvn/TortoiseSVN-1.4.8.12137-win32-svn-1.4.6.msi_

- Tạo một thư mục bất kỳ trên máy của mình (ví dụ ChanhPro), sau đó nhấp phải vào thư mục này chọn "SVN Checkout"

- Tại form Checkout, trong mục URL of repository, gõ vào :

> http://toefl.googlecode.com/svn
> (Thư mục lưu trữ project của mình trên google code)

_Click OK_

- Một bảng hỏi username và password sẽ hiện ra
> + username là tên Account của mình (VD tinyfoot, missfule, latkhtn)
> + pass là do google code cung cấp, mỗi người một cái riêng, lấy bằng cách :

> ++ Vào trang google code của mình http://code.google.com/p/toefl/
> ++ chọn tab Source --> chọn Checkout --> click vào link "googlecode.com password"

_Một số lưu ý :_

> + Lưu ý là project trên đó không gồm CSDL, mọi người down CSDL về đặt
trong thư mục bin/debug để chạy (vì nếu để CSDL lên server thì nó cập
nhật chậm vì nó nặng, mà nó lại hay bị sửa đổi nữa, do quá trình
test).

> + Chỉ cập nhật code của mình khi nó hoàn chỉnh (chạy chính xác, không
làm các phần liên quan bị lỗi) và không làm project bị lỗi, tốt nhất
không nên sửa code của người khác.

> + Trước khi code thì phải Update để lấy phiên bản mới nhất về.

> + Bắt buộc phải có ghi chú về phần mà mình đã update lên.

> + CẬP NHẬT BÀI CỦA MÌNH LÊN SERVER THEO TRÌNH TỰ SAU : UPDATE -> COMMIT (nếu làm theo chiều ngc lại có khi đè mất bài ng khác trên server)
