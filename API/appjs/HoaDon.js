app.controller('mycontroller', function ($scope) {
    $.ajax({
        url: '/api/HoaDon/BangHoaDon',
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: false,
        success: function (data) {
            if (data !== null) {
                $scope.BangHoaDon = data;
                document.getElementById("TongSo").innerHTML = "<b>Total Customer : </b>" + $scope.BangHoaDon.length;
            }
            else
                document.write("Rỗng");
        }
    });

    $scope.LayThongTinHoaDon = function (item) {

        $scope.item = {}
        angular.copy(item, $scope.item)
        console.log($scope.item)
    }

    $scope.XoaHoaDon = function (item) {
        var r = confirm("Do you want delete database ?!"); // thông báo xóa 
        if (r == true) {
            $.ajax({
                url: "/api/HoaDon/XoaHoaDon/",
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

    $scope.CapNhatHoaDon = function () {
        var r = confirm("Do you want save Product ?!");
        if (r == true) {
            $.ajax({
                url: "/api/HoaDon/CapNhatHoaDon/",
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

    // Tao mới khách hàng
    $scope.TaoMoiHoaDon = function () {
        var r = confirm("Do you want Create New Bill ?!");
        if (r == true) {
            $.ajax({
                url: "/api/TaoMoiHoaDon/TaoHoaDonMoi/",
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