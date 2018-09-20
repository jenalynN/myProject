<?php require ('header.php'); ?> 

  <body class="hold-transition skin-red-light sidebar-mini">
	<?php include 'headernav.php'; ?>

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
                      <input type="text" name="table_search" id="searchInput" onkeyup="searchFunc()" class="form-control input-sm pull-right" placeholder="Search. . . .">
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
			   <table id="brandPartnerTable" class="table table-bordered table-hover">
				<tr>
                <tbody>
											<th>Username</th>
											<th>Password</th>  
                                            <th>Last Name</th>
											<th>First Name</th>
											<th>Middle Name</th>
											 
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
	function searchFunc() {
		  var input, filter, table, tr, td, i;
		  input = document.getElementById("searchInput");
		  filter = input.value.toUpperCase();
		  table = document.getElementById("brandPartnerTable");
		  tr = table.getElementsByTagName("tr");
		  for (i = 0; i < tr.length; i++) {
			td = tr[i].getElementsByTagName("td")[0];
			if (td) {
			  if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
				tr[i].style.display = "";
			  } else {
				tr[i].style.display = "none";
			  }
			}       
		  }
		}
    </script>
  </body>
</html>
