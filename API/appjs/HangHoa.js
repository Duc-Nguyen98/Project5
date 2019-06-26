app.controller('mycontroller', function ($scope) {

    $.ajax({
        url: '/api/HangHoa/BangHoangHoa',
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: false,
        success: function (data) {
            if (data !== null) {
                $scope.BangHoangHoa = data;
                document.getElementById("TongSo").innerHTML = "<b>Total Customer : </b>" + $scope.BangHoangHoa.length;
            }
            else
                document.write("Rỗng");
         }
    });

    $scope.XoaHangHoa = function (item) {
        var r = confirm("Do you want delete database ?!"); // thông báo xóa 
        if (r == true) {
            $.ajax({
                url: "/api/HangHoa/XoaHangHoa/",
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


    $scope.LayThongTinHangHoa = function (item) {

        $scope.item = {}
        angular.copy(item, $scope.item)
        console.log($scope.item)
    }

    //Danh mục phân loại
    $.ajax({
        url: '/api/DanhMucPhanLoai/MucPhanLoai',
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: false,
        success: function (data) {
            if (data !== null) {
                $scope.DanhMucPhanLoai = data;
                console.log($scope.DanhMucPhanLoai)
            }
            else
                alert("Không lấy được danh mục phân loại ")
        }
    });

    $scope.CapNhatHangHoa = function () {
        var r = confirm("Do you want save Product ?!");
        if (r == true) {
            $.ajax({
                url: "/api/HangHoa/CapNhatHangHoa/",
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
    //Tao Mới Hàng Hóa
    $scope.TaoMoiHangHoa = function () {
        var r = confirm("Do you want Create New Product ?!");
        if (r == true) {
            $.ajax({
                url: "/api/TaoMoiHangHoa/TaoHangHoaMoi/",
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