app.controller('mycontroller', function ($scope) {


    $.ajax({
        url: '/api/QuanTri/BangQuanTri',
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: false,
        success: function (data) {
            if (data !== null) {
                $scope.BangQuanTri = data;
                document.getElementById("TongSo").innerHTML ="<b>Total Account : </b>" + $scope.BangQuanTri.length;

            }
            else
                document.write("Rỗng");
        }
    });



    $scope.XoaQuanTri = function (item) {
        var r = confirm("Do you want delete database ?!"); // thông báo xóa 
        if (r == true) {
            $.ajax({
                url: "/api/QuanTri/XoaQuanTri/",
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



    $scope.LayThongTinQuanTri = function (item) {

        $scope.item = {}
        angular.copy(item, $scope.item)
        console.log($scope.item)
    }

    // còn đây là load danh mục quyền để đổ vào thẻ select
    $.ajax({
        url: '/api/DanhMucQuyen/PhanQuyen',
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


    $scope.CapNhatQuanTri = function () {
        var r = confirm("Do you want save Empolyee ?!");
        if (r == true) {
            $.ajax({
                url: "/api/QuanTri/CapNhatQuanTri/",
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

    $scope.TaoMoiNguoiDung = function () {
        var r = confirm("Do you want Create New Empolyee ?!");
        if (r == true) {
            $.ajax({
                url: "/api/TaoMoiNguoiDung/TaoNguoiDungMoi/",
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

