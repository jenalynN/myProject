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
					
                    <div class="panel_body" align="left">
						<form action="barChart.php" method="post">
							<b>From:</b>
							<input type="date" name="fromdate" id="fromdate" placeholder="From">
							<b>To: </b>
							<input type="date" name="todate" id="todate" placeholder="To">  
							<input class = "btn btn-danger btn-md" type="submit" id="submit" name="submit" value="GO"  onclick="searchDate();">
						</form>
					</div>
			   </div>

			   <div class="box box-success">
                <div class="box-header with-border">
                  <h3 class="box-title">Bar Chart</h3>
                  <div class="box-tools pull-right">
                    <button class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                    <button class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
                  </div>
                </div>
                <div class="box-body">
                  <div class="chart">
                    <canvas id="barChart" style="height: 231px; width: 514px;" width="514" height="231"></canvas>
                  </div>
                </div><!-- /.box-body -->
              </div>
			   
                </div><!-- /.box-body -->
              </div><!-- /.box -->
          
              
            </div><!-- /.col -->
          </div><!-- /.row -->
        </section><!-- /.content -->
      </div><!-- /.content-wrapper -->
<?php 
//header_remove(); 
 include ('dataChart.php'); 
 ?>   
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
	<!-- ChartJS 1.0.1 -->
    <script src="plugins/chartjs/Chart.min.js"></script>

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
	  $(function () {
        /* ChartJS
         * -------
         * Here we will create a few charts using ChartJS
         */
		 function filterFile()
		 {
			 var myfile;
			if(document.getElementById('submit').clicked == true)
			{
				myfile = "dataChartFilter.php";
			}
			else
			{
				myfile = "dataChart.php";
				//myfile = "dataChartFilter.php";
			}
			return myfile;
		 }
				
		$.ajax({
			
		
		url: "dataChart.php", //filterFile(),
		dataType: "json",
		method: "POST",
		success: function(data) {
			console.log(data);
			var date = [];
			var sales = [];

			for(var i in data) {
				date.push(data[i].date);
				sales.push(data[i].sales);
			}

			var areaChartData = {
				labels: date,
				datasets : [
					{
						label: 'Daily Sales',
						backgroundColor: 'rgba(200, 200, 200, 0.75)',
						borderColor: 'rgba(200, 200, 200, 0.75)',
						hoverBackgroundColor: 'rgba(200, 200, 200, 1)',
						hoverBorderColor: 'rgba(200, 200, 200, 1)',
						data: sales
					}
				]
			};

		//-------------
        //- BAR CHART -
        //-------------
        var barChartCanvas = $("#barChart").get(0).getContext("2d");
        var barChart = new Chart(barChartCanvas);
        var barChartData = areaChartData;
        var barChartOptions = {
          //Boolean - Whether the scale should start at zero, or an order of magnitude down from the lowest value
          scaleBeginAtZero: true,
          //Boolean - Whether grid lines are shown across the chart
          scaleShowGridLines: true,
          //String - Colour of the grid lines
          scaleGridLineColor: "rgba(0,0,0,.05)",
          //Number - Width of the grid lines
          scaleGridLineWidth: 1,
          //Boolean - Whether to show horizontal lines (except X axis)
          scaleShowHorizontalLines: true,
          //Boolean - Whether to show vertical lines (except Y axis)
          scaleShowVerticalLines: true,
          //Boolean - If there is a stroke on each bar
          barShowStroke: true,
          //Number - Pixel width of the bar stroke
          barStrokeWidth: 2,
          //Number - Spacing between each of the X value sets
          barValueSpacing: 5,
          //Number - Spacing between data sets within X values
          barDatasetSpacing: 1,
          //String - A legend template
          legendTemplate: "<ul class=\"<%=name.toLowerCase()%>-legend\"><% for (var i=0; i<datasets.length; i++){%><li><span style=\"background-color:<%=datasets[i].fillColor%>\"></span><%if(datasets[i].label){%><%=datasets[i].label%><%}%></li><%}%></ul>",
          //Boolean - whether to make the chart responsive
          responsive: true,
          maintainAspectRatio: true
		};

        barChartOptions.datasetFill = false;
        barChart.Bar(barChartData, barChartOptions);	
		},
		error: function(data) {
			console.log(data);
		}
	});

	});
	
	
	$(function searchDate() {
        /* ChartJS
         * -------
         * Here we will create a few charts using ChartJS
         */
		 
			console.log(data);
			var date = [];
			var sales = [];

			for(var i in data) {
				date.push(data[i].date);
				sales.push(data[i].sales);
			}

			var areaChartData = {
				labels: date,
				datasets : [
					{
						label: 'Daily Sales',
						backgroundColor: 'rgba(200, 200, 200, 0.75)',
						borderColor: 'rgba(200, 200, 200, 0.75)',
						hoverBackgroundColor: 'rgba(200, 200, 200, 1)',
						hoverBorderColor: 'rgba(200, 200, 200, 1)',
						data: sales
					}
				]
			};

		//-------------
        //- BAR CHART -
        //-------------
        var barChartCanvas = $("#barChart").get(0).getContext("2d");
        var barChart = new Chart(barChartCanvas);
        var barChartData = areaChartData;
        var barChartOptions = {
			  //Boolean - Whether the scale should start at zero, or an order of magnitude down from the lowest value
			  scaleBeginAtZero: true,
			  //Boolean - Whether grid lines are shown across the chart
			  scaleShowGridLines: true,
			  //String - Colour of the grid lines
			  scaleGridLineColor: "rgba(0,0,0,.05)",
			  //Number - Width of the grid lines
			  scaleGridLineWidth: 1,
			  //Boolean - Whether to show horizontal lines (except X axis)
			  scaleShowHorizontalLines: true,
			  //Boolean - Whether to show vertical lines (except Y axis)
			  scaleShowVerticalLines: true,
			  //Boolean - If there is a stroke on each bar
			  barShowStroke: true,
			  //Number - Pixel width of the bar stroke
			  barStrokeWidth: 2,
			  //Number - Spacing between each of the X value sets
			  barValueSpacing: 5,
			  //Number - Spacing between data sets within X values
			  barDatasetSpacing: 1,
			  //String - A legend template
			  legendTemplate: "<ul class=\"<%=name.toLowerCase()%>-legend\"><% for (var i=0; i<datasets.length; i++){%><li><span style=\"background-color:<%=datasets[i].fillColor%>\"></span><%if(datasets[i].label){%><%=datasets[i].label%><%}%></li><%}%></ul>",
			  //Boolean - whether to make the chart responsive
			  responsive: true,
			  maintainAspectRatio: true
			};

			barChartOptions.datasetFill = false;
			barChart.Bar(barChartData, barChartOptions);	
			
		

	});
    </script>
  </body>
</html>
