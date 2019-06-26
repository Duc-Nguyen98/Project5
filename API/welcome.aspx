<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="API.welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://code.jquery.com/jquery-1.12.3.min.js"></script>
    <!-- Bootstrap CSS -->
     <script src="https://code.jquery.com/jquery-1.12.3.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel="stylesheet" href="welcome.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">



    <title>Adminstrator</title>
</head>
<body>
       <script type="text/javascript" src="script.js"></script>
   
   <div class="wrapper">
    <nav id="sidebar">
      <div class="sidebar-header">
        <h3>Larva shop</h3>
      </div>
      
      
      <ul class="list-unstyled components">
        <p></p>
     <li class="active">
          <a href="welcome.aspx" data-toggle="collapse" aria-expanded="false">Home</a>

     </li>
        
        <li>
          <a href="#">About</a>
        </li>
        <li>
          <a href="#pageSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Page</a>
          <ul class="collapse list-unstyled" id="pageSubmenu">
            <li>
              <a href="QuanTri.html"><i class="fa fa-user-secret" style="margin-left: -15px;font-size: 25px;float: left;padding-right: 15px;margin-top: -3px;"></i>Administrator<i class="fa fa-plus" style="float:right;padding-right: 11px;font-size: 20px;"></i></a>
            </li>
            <li>
              <a href="KhachHang.html"><i class="fa fa-users" style="margin-left: -15px;font-size: 25px;float: left;padding-right: 15px;margin-top: -3px;"></i>Customer<i class="fa fa-plus" style="float:right;padding-right: 11px;font-size: 20px;"></i></a>
            </li>
            <li>
              <a href="NhanVien.html"><i class="fas fa-user-tie" style="margin-left: -15px;font-size: 25px;float: left;padding-right: 15px;margin-top: -3px;"></i>Employees<i class="fa fa-plus" style="float:right;padding-right: 11px;font-size: 20px;"></i></a>
            </li>
             <li>
              <a href="HangHoa.html"><i class="fa fa-cubes" style="margin-left: -15px;font-size: 25px;float: left;padding-right: 15px;margin-top: -3px;"></i>Products<i class="fa fa-plus" style="float:right;padding-right: 11px;font-size: 20px;"></i></a>
            </li>
            <li>
              <a href="HoaDon.html"><i class="fa fa-file-invoice-dollar" style="margin-left: -15px;font-size: 25px;float: left;padding-right: 15px;margin-top: -3px;"></i>Bill<i class="fa fa-plus" style="float:right;padding-right: 11px;font-size: 20px;"></i></a>
            </li>

          </ul> 
        </li>
        <li>
          <a href="#">Services</a>
        </li>
        <li>
          <a href="#">Contact Us</a>
        </li>
      </ul>
      
      <ul class="list-unstyled CTAs">
        <li>
            <form id="form1" runat="server" >
                <div>
                    <asp:Button ID="btnlogout"   runat="server" Text="Logout" CssClass="logout" OnClick="btnlogout_Click" />
                </div>
            </form>
        </li>
      </ul>
    </nav>
    <div class="content">
    
        <nav class="navbar navbar-expand-lg navbar-light bg-light">

            <button type="button" id="sidebarCollapse" class="btn btn-info">
                <i class="fa fa-align-justify"></i> <span></span>
            </button>

            <!--<a class="navbar-brand" href="#">Navbar</a> -->


        </nav>
        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">

            <ol class="carousel-indicators">
                <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
            </ol>

            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="d-block w-100"  src="images/anhbanh1.jpg" />
                </div> <!-- End carousel-item active -->
                

                <div class="carousel-item">
                    <img class="d-block w-100 " src="images/anhbanh2.jpg" />
                </div> <!-- End carousel-item -->

                <div class="carousel-item">
                    <img class="d-block w-100"src="images/anhbanh1.jpg" />
                </div> <!-- End carousel-item -->
            </div>
            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>

        <div class="line"></div>
        <div class="col-xs-6 push-xs-3">
            <div class="text-xs-center">
                <h2 class="display-4">How Can Pastry Help You?</h2>
                <p class="lead text-sm-center my-3 py-3">Something short and leading about the collection below—its contents, the creator, etc. Make it short and sweet, but not too short so folks don't simply skip over it entirely.</p>
            </div>
        </div>

        <!-- Optional JavaScript -->
        <!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

        <script>
            $(document).ready(function () {
                $('#sidebarCollapse').on('click', function () {
                    $('#sidebar').toggleClass('active');
                });
            });
        </script>



        <div class="nds1">
            <div class="container">
                <div class="row td">
                </div><!--  het row chua tieu de  -->
                <div class="row s1">
                    <div class="col-sm-4">
                        <div class="row tren">
                            <div class="col-sm-12 mb-3">
                                <h3 class="mb-2">Save you time and effort</h3>
                                <p>
                                    Explain one of your product benefits here. Let users know how they can benefit using your product. It’s also a good idea to back it up with a testimonial or tweet from your users.
                                    The original PSD of the graphic is included in the package. You can easily customise the PSD to meet your needs.
                                </p>
                            </div> <!-- End col-sm-12 mb-3 -->
                        </div> <!-- End row tren -->

                        <div class="row">
                            <div class="col-sm-3">
                                <img src="images/2.png" alt="" class="img-fluid">
                            </div> <!-- End col-sm-3 -->
                        </div> <!-- End row -->

                    </div> <!-- End col-sm-4 -->

                    <div class="col-sm-1"></div>

                    <div class="col-sm-7">
                        <img src="images/1.png" alt="" class="img-fluid">
                    </div>  <!-- End col-sm-7 -->
                </div> <!-- het row so 1  -->

                <div class="row vien mb-2 mt-2">
                    <div class="col-sm-12">
                        <hr>
                    </div> <!-- End col-sm-12 -->
                </div> <!-- End row vien mb-2 mt-2 -->



                <div class="row s3">
                    <div class="col-sm-4">
                        <div class="row tren">
                            <div class="col-sm-12 mb-3">
                                <h3 class="mb-2">Save you time and effort</h3>
                                <p>
                                    Explain one of your product benefits here. Let users know how they can benefit using your product. It’s also a good idea to back it up with a testimonial or tweet from your users.
                                    The original PSD of the graphic is included in the package. You can easily customise the PSD to meet your needs.
                                </p>
                            </div> <!-- End col-sm-12 mb-3 -->
                        </div> <!-- End row tren -->

                        <div class="row">
                            <div class="col-sm-3">
                                <img src="images/2.png" alt="" class="img-fluid">
                            </div> <!-- End col-sm-3 -->
                        </div> <!-- End row -->
                    </div> <!-- End row -->

                    <div class="col-sm-1"></div>

                    <div class="col-sm-7">
                        <img src="images/3.png" alt="" class="img-fluid">
                    </div>
                </div> <!-- End col-sm-7  -->

                <div class="row vien mb-2 mt-2">
                    <div class="col-sm-12">
                        <hr>
                    </div> <!-- End col-sm-12 -->
                </div> <!-- End row vien mb-2 mt-2 -->

                <div class="row s4">
                    <div class="col-sm-12 text-sm-center mb-3">
                        <p class="thechu my-3">Want to discover all the features?</p>
                        <a href="" class="btn btn-outline-danger"> Take a tour </a>
                    </div>
                </div> <!-- End row s4 -->

            </div> <!-- het container -->
        </div> <!-- het nds1 -->

        <div class="top">
            <div class="banner">
                <div class="container">
                    <div class="row">
                        <div class="col-sm-12 push-sm-2 text-sm-center">
                            <h1>Let's get your product online fast <br>  and get attention right away!</h1>
                            <p>
                                Velocity is a mobile-friendly HTML5 template designed to help you <br>
                                promote your product effectively to your target users
                            </p>
                            <a href="" class="btn btn-danger">Try velocity Free </a>
                        </div>
                    </div> <!-- het row -->
                </div><!--  het container  -->
            </div> <!-- het banner -->
        </div><!--  het top -->

        <div class="navbar-fixed-bottom ">
            <b class="btn btn-primary nutlen float-xs-right">
                <i class="fa fa-chevron-up "></i>
            </b> <!-- End btn btn-primary nutlen float-xs-right -->
        </div>  <!-- End navbar-fixed-bottom -->

        <div class="footer">
            <div class="col-xs-12 text-sm-center">
                <a>© Copyright 2019 All rights reserved, <b>Design by ATO Company</b></a>
            </div>
        </div>  <!-- End footer -->

</body>
</html>
