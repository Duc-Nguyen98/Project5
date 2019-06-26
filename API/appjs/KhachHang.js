app.controller('mycontroller', function ($scope) {

    
    $.ajax({
        url: '/api/KhachHang/BangKhachHang',
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: false,
        success: function (data) {
            if (data !== null) {
                $scope.BangKhachHang = data;
                document.getElementById("TongSo").innerHTML = "<b>Total Customer : </b>" + $scope.BangKhachHang.length;
            }
            else
                document.write("Rỗng");
        }
    });


    $scope.LayThongTinKhachHang = function (item) {

        $scope.item = {}
        angular.copy(item, $scope.item)
        console.log($scope.item)
    }

    $scope.XoaKhachHang = function (item) {
        var r = confirm("Do you want delete database ?!"); // thông báo xóa 
        if (r == true) {
            $.ajax({
                url: "/api/KhachHang/XoaKhachHang/",
                type: "delete",
                dataType: "text",
                data: item,
                success: function (result) {
                    alert("Xóa Thành Công !");
                    init_reload();
                    function init_reload() {
                        setInterval(function () {
                            window.location.reload();

                        }, 100);
                    }
                }
            });
        }
        else {
            return;
        }
    }

    $scope.CapNhatKhachHang = function () {
        var r = confirm("Do you want save Empolyee ?!");
        if (r == true) {
            $.ajax({
                url: "/api/KhachHang/CapNhatKhachHang/",
                type: "post",
                dataType: "text",
                data: $scope.item,
                success: function (result) {
                    alert("Cập Nhật Thành Công !");
                    init_reload();
                    function init_reload() {
                        setInterval(function () {
                            window.location.reload();

                        }, 100);
                    }
                }
            });
        }
        else {
            return;
        }
    }


    //Danh mục thành phố
    $.ajax({
        url: '/api/DanhMucThanhPho/MucThanhPho',
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: false,
        success: function (data) {
            if (data !== null) {
                $scope.DanhMucThanhPho = data;
                console.log($scope.DanhMucThanhPho)
            }
            else
                alert("Không lấy được danh mục thành phố ")
        }
    });

    // Tao mới khách hàng
    $scope.TaoMoiKhachHang = function () {
        var r = confirm("Do you want Create New Customer ?!");
        if (r == true) {
            $.ajax({
                url: "/api/TaoMoiKhachHang/TaoKhachHangMoi/",
                type: "post",
                dataType: "text",
                data: $scope.item,
                success: function (result) {
                    alert("Cập Nhật Thành Công !");
                    init_reload();
                    function init_reload() {
                        setInterval(function () {
                            window.location.reload();

                        }, 100);
                    }
                }
            });
        }
        else {

            return;
            alert("Thất Bại");
        }
    }

});
