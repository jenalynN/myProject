<?php 	
include 'db.php';
include 'functions.php';
include 'header.php';

?>
<style>
.box{
    width: 300px;
    height: 100px;
    border: 1px solid black;
    box-sizing: border-box;
}
body {
	background-color:lightblue;
}

</style



<!DOCTYPE html>
<html>
<body>

<div class="container"> 
	<div class="row">
		<div class="col-sm-6">
			Check-in:
			<input type="date" name="" value="">
			 Check-out: 
			<input type="date" name="" value="">
		</div>
	</div>
	<?php
		 $sql = "SELECT * FROM tb_motor";
		$result = selectData($sql);
 		while($row = $result->fetch_assoc()) {
			?>
	<div class="row">
		<div class="col-sm-4">
			<div class="item">
				<br><img src="<?php echo $row["picture"]; ?>" style="width:80%;"></br>
			</div>
		 </div>
		 
		<div class="col-sm-6">
			<div class="panel-group">
				<div class="panel panel-primary">
					<div class="panel-heading"> 
						<h1 class="panel-title text-center">Discription</h1>
					</div>
					<div class="panel-body">
						<table class="table">
							<tr>
								<td>PlateNo:</td>
							<?php	echo "<td>".$row["plateNo"]."</td>"; ?>
							</tr>
							<tr>
								<td>Color:</td>
							<?php	echo "<td>".$row["color"]."</td>"; ?>
							</tr>
							<tr>
								<td>Brand:</td>
							<?php	echo "<td>".$row["brand"]."</td>"; ?>
							</tr>
							<tr>
								<td>Type:</td>
							<?php	echo "<td>".$row["type"]."</td>"; ?>
							</tr>
							<tr>
								<td>Rate:</td>
							<?php	echo "<td>".$row["rate"]."</td>"; ?>
							</tr>
						</table>
					</div>
				</div>
			</div>
		</div>
		<div class="col-sm-2">
				<button type="button" class="btn btn-primary">Reserve</button>
			
		</div>
	</div>
		<?php } ?>
	

 
 


</body>
</html>