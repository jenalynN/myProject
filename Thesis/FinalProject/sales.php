<?php require ('header.php'); ?> 

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
                      <div class="input-group" style="width: 300px;" align="right" >
                          <input type="text" name="table_search" class="form-control input-sm pull-right" placeholder="Search. . . .">
                      <div class="input-group-btn">
                          <button class="btn btn-sm btn-danger"><i class="fa fa-search"></i></button>
                      </div>  
			  </div>
                  
			<div class="panel_body" align="right">
			  
			<b>From:</b>
      <input type="date" name="fromdate" id="fromdate" placeholder="From">
			<b>To: </b>
      <input type="date" name="todate" id="todate" placeholder="To">  
			<button class = "btn btn-danger btn-md">GO</button>
			</div>
			
			<table id="example2" class="table table-bordered table-hover">
			<tr>
            <tbody>
                      <th>Date Purchased</th>
                      <th>Transaction Code</th>
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
		
<div class="col-md-3 col-sm-6 col-xs-12">


<div class="info-box">
  <span class="info-box-icon bg-red"></span>
  <div class="info-box-content">

    <span class="info-box-text">Number of Transactions</span>
    <span class="info-box-number"> <?php
      $db = mysqli_connect('localhost', 'root', '','db_poshconceptstorefinal');
      if (!$db){trigger_error('Could not connect to MySQL: ' . mysqli_connect_error());}	
      $result=mysqli_query($db, 'SELECT Count(col_transactioncode) as sales FROM tbl_transaction');
      $row = mysqli_fetch_assoc($result);
      $sum = $row['sales'];
      echo $sum;
    ?></span>
  </div><!-- /.info-box-content -->
</div><!-- /.info-box -->
</div>
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
									  $result=mysqli_query($db, 'SELECT Count(col_orderstatus) as sales FROM tbl_order where col_orderstatus="Sales"');
									  $row = mysqli_fetch_assoc($result);
									  $sum = $row['sales'];
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
									  $result=mysqli_query($db, 'SELECT Count(col_orderstatus) as void from tbl_order where col_orderstatus="Void"');

									  $row = mysqli_fetch_assoc($result);
									  $sum = $row['void'];
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
