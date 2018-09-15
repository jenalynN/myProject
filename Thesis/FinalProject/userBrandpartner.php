<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Posh and Fab Concept Store | Online Viewing</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=5s, user-scalable=yes" name="viewport">
    <!-- Bootstrap 3.3.5 -->
    <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <!-- DataTables -->
    <link rel="stylesheet" href="datatables/dataTables.bootstrap.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="dist/css/AdminLTE.min.css">
    <!-- AdminLTE Skins. Choose a skin from the css/skins
         folder instead of downloading all of them to reduce the load. -->
    <link rel="stylesheet" href="dist/css/skins/_all-skins.min.css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>
  <body class="hold-transition skin-red-light sidebar-mini">
<header class="main-header">
        <!-- Logo -->
        <a href="data.php" class="logo">
          <!-- mini logo for sidebar mini 50x50 pixels -->
          <span class="logo-mini">PCS</span>
          <!-- logo for regular state and mobile devices -->
          <span class="logo-lg">Posh Concept Store </span>
        </a>
        <!-- Header Navbar: style can be found in header.less -->
        <nav class="navbar navbar-static-top" role="navigation">
          <!-- Sidebar toggle button-->
          <a href="#" class="sidebar-toggle" data-toggle="offcanvas" role="button">
            <span class="sr-only">Toggle navigation</span>
           
          </a>
          <div class="navbar-custom-menu">
            <ul class="nav navbar-nav">
              <!-- Messages: style can be found in dropdown.less-->
              
                        
              <!-- Notifications: style can be found in dropdown.less -->
             
              <!-- User Account: style can be found in dropdown.less -->
              <li class="dropdown user user-menu">
                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                  <span class="hidden-xs">Alexander Pierce</span>
                </a>
                <ul class="dropdown-menu">
                  <!-- User image -->
                  
                  <!-- Menu Body -->
                  
                  <!-- Menu Footer-->
                  <li class="user-footer">
                    <div class="pull-left">
                      <a href="#" class="btn btn-default btn-flat">Profile</a>
                    </div>
                    <div class="pull-right">
                      <a href="#" class="btn btn-default btn-flat">Sign out</a>
                    </div>
                  </li>
				  
                </ul>
              </li>
              <!-- Control Sidebar Toggle Button -->
             
            </ul>
          </div>
        </nav>
      </header>
	  
      
  
          <!-- Sidebar user panel -->
         
          <!-- search form -->
		  <aside class="main-sidebar">
        <!-- sidebar: style can be found in sidebar.less -->
        <section class="sidebar" style="height: auto;">
          
          <ul class="sidebar-menu">
		  <li>
		   <a href="Dashboard.php">
                <i class="fa fa-pie-chart"></i>
                <span>Dashboard</span>
                
              </a>
			  </li>
            <li>
              <a href="sales.php">
                <i class="fa fa-cart-arrow-down"></i> <span>Sales</span> 
              </a>
            </li>
            <li class="treeview">
              <a href="#">
                <i class="fa fa-pie-chart"></i>
                <span>Charts and Graphs</span>
                <i class="fa fa-angle-left pull-right"></i>
              </a>
              <ul class="treeview-menu">
                <li><a href="../charts/chartjs.html"><i class="fa fa-circle-o"></i> Pie Charts</a></li>
				<li><a href="../charts/chartjs.html"><i class="fa fa-circle-o"></i> Bar Graphs</a></li>
              </ul>
            </li>
			
			<li class="treeview">
              <a href="#">
                <i class="fa fa-user"></i>
                <span>User Accounts</span>
                <i class="fa fa-angle-left pull-right"></i>
              </a>
              <ul class="treeview-menu">
                <li><a href="userCashier.php"><i class="fa fa-circle-o"></i> Cashier</a></li>
				<li><a href="userBrandpartner.php"><i class="fa fa-circle-o"></i> Brand Partners</a></li>
              </ul>
            </li>
            
            <li class="treeview">
              <a href="#">
                <i class="fa fa-th"></i> <span>Products</span>
                <i class="fa fa-angle-left pull-right"></i>
              </a>
              <ul class="treeview-menu">
                <li><a href="damage.php"><i class="fa fa-circle-o"></i> Damage</a></li>
                <li><a href="../forms/advanced.html"><i class="fa fa-circle-o"></i> Fix</a></li>
              </ul>
            </li>
           
         
        </section>
        <!-- /.sidebar -->
			</ul>
      </aside>
      <!-- Add the sidebar's background. This div must be placed
           immediately after the control sidebar -->
   </section>
   <div class= "content-wrapper">

        <section class="content-header">
         <h1>
              <h1> Brand Partner Table </h1>
          </h1>
         
        </section>

        <!-- Main content -->
        <section class="content">

              <div class="box">
			
                <div class="box-body">

                    <div class="input-group" style="width: 300px;" align="right" >
                      <input type="text" name="table_search" class="form-control input-sm pull-right" placeholder="Search. . . .">
                      <div class="input-group-btn">
                        <button class="btn btn-sm btn-danger"><i class="fa fa-search"></i></button>
                      </div>	
                    </div>
					
							<!--div class="panel_body" align="right">
			<b>From:</b>
			<input type="date" name="" value="">
			<b>To:</b>
			<input type="date" name="" value="">
               </div-->
			   </div>
			   <table id="example2" class="table table-bordered table-hover">
				<tr>
                <tbody>
                                            <th>Last Name</th>
											<th>First Name</th>
											<th>Middle Name</th>
											<th>Username</th>
											<th>Password</th>  
                                            <th> Status</th>	
											 
											 <?php
									require 'Controller/bpquery.php'
									?>
                                        
                   
				   
                                    <?php 
									
                                    view_user();
                                    ?>
                                        
                                    </tbody>
									</tr>
									</table>


                </div><!-- /.box-body -->
              </div><!-- /.box -->
          
              
            </div><!-- /.col -->
          </div><!-- /.row -->
        </section><!-- /.content -->
      </div><!-- /.content-wrapper -->
     
      <div class="control-sidebar-bg"></div>
    </div><!-- ./wrapper -->

    <!-- jQuery 2.1.4 -->
    <script src="plugins/jQuery/jQuery-2.1.4.min.js"></script>
    <!-- Bootstrap 3.3.5 -->
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <!-- DataTables -->
    <script src="datatables/jquery.dataTables.min.js"></script>
    <script src="datatables/dataTables.bootstrap.min.js"></script>
    <!-- SlimScroll -->
    <script src="plugins/slimScroll/jquery.slimscroll.min.js"></script>
    <!-- FastClick -->
    <script src="plugins/fastclick/fastclick.min.js"></script>
    <!-- AdminLTE App -->
    <script src="dist/js/app.min.js"></script>
    <!-- AdminLTE for demo purposes -->
    <script src="dist/js/demo.js"></script>
    <!-- page script -->
    <script>
      $(function ()
	  {
        $('#example2').DataTable(
		{
			
		  "responsive": true,
          "paging": true,
          "lengthChange": false,
          "searching": false,
          "ordering": true,
          "info": true,
          "autoWidth": false,
          
        });
      });
    </script>
  </body>
</html>
