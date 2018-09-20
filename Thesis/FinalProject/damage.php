<?php require ('header.php'); ?> 

  <body class="hold-transition skin-red-light sidebar-mini">
 <?php include 'headernav.php'; ?>

 <div class= "content-wrapper">

        <section class="content-header">
         <h1>
              <h1> Damage Product </h1>
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
                                            <th>Transaction Code</th>
											                      <th>Product Code</th>
                                            <th>Product Name</th>
                                            <th>Product Price</th>
											
											<?php
									require 'Controller/damagequery.php'
									?>
                                        
                   
				   
                                    <?php 
									
                                    view_product();
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
    <script src="/datatables/jquery.dataTables.min.js"></script>
    <script src="/datatables/dataTables.bootstrap.min.js"></script>
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
