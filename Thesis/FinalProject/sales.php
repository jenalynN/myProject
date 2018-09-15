<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Posh Concept Store | Online Viewing</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=5s, user-scalable=yes" name="viewport">
    <!-- Bootstrap 3.3.5 -->
	<link rel="stylesheet" href="plugins/datepicker/datepicker3.css">
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
	<?php include 'headernav.php'; ?>
   
   <div class="content-wrapper">

    
	   <section class="content-header">
          <h1>
           <h1> Sales Table </h1>
          </h1>
          
        </section>
      <!-- Left side column. contains the logo and sidebar -->
    

      <!-- Content Wrapper. Contains page content --
        <!-- Content Header (Page header) -->
		

        <!-- Main content -->
        <section class="content">
		       
              <div class="box">
			
               <div class="box-body">

                  
			<div class="panel_body" align="right">
			  
			<b>From:</b>
			<input type="text" readonly class="" name="fromdate" id="fromdate" >
			<b>To: </b>
			<input type="date"  name="todate" id="todate" >
			
			</div>
			
			<table id="example2" class="table table-bordered table-hover">
			<tr>
            <tbody>
                                            <th>Transaction Code</th>
											<th>Date Purchased</th>
											<th>Product Code</th>
                                            <th>Product Name</th>
                                            <th>Product Price</th>
											<th>Number of Product Sold</th>
											<th>SubTotal</th>
											<th>Order Type</th>

											
                  <?php
									require 'Controller/salesquery.php'
									?>
									<?php
                                    view_sales();
                                    ?>
                                    </tbody>
									</tr>
									
                        
									</table>
                  
								

              </div><!-- /.box -->
          <!-- /.col -->

        </section>
		  <section class="content">
		
              <div class="row">
            <div class="col-md-3 col-sm-6 col-xs-12">
              <div class="info-box">
                <span class="info-box-icon bg-aqua"> </span>
                <div class="info-box-content">
				
                  <span class="info-box-text">Total Sales</span>
                  <span class="info-box-number"> 
									<?php
									  $db = mysqli_connect('localhost', 'root', '','db_poshconceptstorefinal');
									  if (!$db){trigger_error('Could not connect to MySQL: ' . mysqli_connect_error());}	
									  $result=mysqli_query($db, 'SELECT SUM(col_totalprice) as value FROM tbl_transaction');
									  $row = mysqli_fetch_assoc($result);
									  $sum = $row['value'];
									  echo $sum;
									?>
				  </span>
				  
                </div><!-- /.info-box-content -->
				
              </div><!-- /.info-box -->
			  
			  
			  
					</div>
<div class="col-md-3 col-sm-6 col-xs-12">


              <div class="info-box">
                <span class="info-box-icon bg-green"></span>
                <div class="info-box-content">
				
                  <span class="info-box-text">Number of Sales</span>
                  <span class="info-box-number"> <?php
									  $db = mysqli_connect('localhost', 'root', '','db_poshconceptstorefinal');
									  if (!$db){trigger_error('Could not connect to MySQL: ' . mysqli_connect_error());}	
									  $result=mysqli_query($db, 'SELECT Count(col_totalprice) as value FROM tbl_transaction');
									  $row = mysqli_fetch_assoc($result);
									  $sum = $row['value'];
									  echo $sum;
									?></span>
                </div><!-- /.info-box-content -->
              </div><!-- /.info-box -->
					</div>
<div class="col-md-3 col-sm-6 col-xs-12">
              <div class="info-box">
                <span class="info-box-icon bg-yellow"></span>
                <div class="info-box-content">
				
                  <span class="info-box-text">Void Items</span>
                  <span class="info-box-number"> <?php
									  $db = mysqli_connect('localhost', 'root', '','db_poshconceptstorefinal');
									  if (!$db){trigger_error('Could not connect to MySQL: ' . mysqli_connect_error());}	
									  $result=mysqli_query($db, 'SELECT Count(col_totalprice) as value FROM tbl_transaction');
									  $row = mysqli_fetch_assoc($result);
									  $sum = $row['value'];
									  echo $sum;
									?></span>
                </div><!-- /.info-box-content -->
              </div><!-- /.info-box -->
					</div>
					</DIV	>
						
						
						</DIV	>
						
            
         
     </div>
	 
		</section>
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
	<script src="plugins/datepicker/bootstrap-datepicker.js"></script>
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
          "searching": true,
          "ordering": true,
          "info": true,
          "autoWidth": true,
          
        });
		 $('#fromdate').datepicker(
		{
			
		  "format":	 'yyyy-dd-mm',
          "autoclose":true;
          
        });
		
      });
    </script>
	  
	
  </body>
</html>
