<?php 
include 'db.php';
include 'functions.php';
include 'header.php';
?>
<style>
body {
	background-color:lightblue;
}
</style>

<body>
<div class="container">
	<h3>House Reservation</h3>
	<div class="row">
		<div class="col-sm-12">
			<div class="panel panel-default">
			<div class="panel-body">
			<form action='motor_reserve.php' method="post">
				<table>
					<tr>
						<td class="col-sm-1">From:</td>
							<td><input type="date" name="from"></td>
						
						<td  class="col-sm-1">To:</td>
							<td><input type="date" name="to"></td>

					</tr>
				</table>
			</form>
			</div>
			</div>
		</div>
	</div>

<?php
		$sql = "SELECT * FROM tb_house ";
		$result = selectData ($sql);
		while($row = $result->fetch_assoc()) {
			?>
<div class="row">
	<div class="col-sm-4">
		 <div class="item">
			<br><img src="<?php echo $row["Picture"]; ?>" style="width:80%;"></br>
		</div>			
	</div>
	<div class="col-sm-4">
			<div class="panel-group">
				<div class="panel panel-primary">
					<div class="panel-heading"> 
						<h1 class="panel-title text-center">Description</h1>
					</div>
					<div class="panel-body">
						<table class="table">
						<tr>
							<td>Area:</td>
						<?php echo"	<td>".$row["Area"]."sqm </td>"?>
						</tr>
						<tr>
							<td>BedRoom:</td>
						<?php echo"<td>".$row["BedRoom"]."</td>"?>
						</tr>
						<tr>
							<td>BathRoom:</td>
						<?php echo"<td>".$row["BathRoom"]."</td>"?>
						</tr>
						<tr>
							<td>Rate:</td>
						<?php echo"	<td> ₱".$row["Rate"]."</td>"?>
						</tr>
						</table>
					</div>
				</div>
			</div>		
		</div>
		<a href= "h_details.php" class= 'btn btn-primary' >Reserve</a>	
</div>	
		<?php }?>
</div>			
</body>