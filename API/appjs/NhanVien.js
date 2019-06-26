app.controller('mycontroller', function ($scope) {   

    $scope.haha = "OKe";
    $.ajax({
        url: '/api/NhanVien/Bangnhanvien',
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: false,
        success: function (data) {
            if (data !== null) {
                $scope.BangNhanVien = data;
                document.getElementById("TongSo").innerHTML = "<b>Total Account : </b>" + $scope.BangNhanVien.length;
            }
            else
                document.write("Rỗng");
        }
    });




    $scope.LayThongTinNhanVien = function (item) {

        $scope.item = {}
        angular.copy(item, $scope.item)
        console.log($scope.item)
    }

    $scope.XoaNhanVien = function (item) {
        var r = confirm("Do you want delete database ?!"); // thông báo xóa 
        if (r == true) {
            $.ajax({
                url: "/api/NhanVien/XoaNhanVien/",
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
    // hàm load

    $scope.CapNhatNhanVien = function () {
        var r = confirm("Do you want save Empolyee ?!");
        if (r == true) {
            $.ajax({
                url: "/api/NhanVien/CapNhatNhanVien/",
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



    $scope.TaoMoiNhanVien = function () {
        var r = confirm("Do you want Create New Empolyee ?!");
        if (r == true) {
            $.ajax({
                url: "/api/TaoMoiNhanVien/TaoNhanVienMoi/",
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



    // Phân quyền
    $.ajax({
        url: '/api/DanhMucQuyen/MucQuyen',
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: false,
        success: function (data) {
            if (data !== null) {
                $scope.DanhMucQuyen = data;
                console.log($scope.DanhMucQuyen)
            }
            else
                alert("Không lấy được danh mục quyền")
        }
    });



});

