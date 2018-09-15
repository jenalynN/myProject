<?php 
include 'db.php';
include 'functions.php';
include 'header.php';
 
?>
<?php

if (!empty($_POST["Confirm"])){
		$id = $_POST["reservationID"];
	//$sql = "UPDATE t_customer SET name='Doe' WHERE id=1";
	//updateData($sql);

	$sql = "UPDATE tb_reservation SET status='Confirm' where reservationID=$id";
	updateData($sql);
	echo $sql;
}

?>


<style>
body {
	 background-image: url("img/mm.JPG");
     background-size: 1400px;500px;
     background-repeat: no-repeat;
	background-color:lightblue;
}

table {

	font-family: arial, sans-serif;
    border-collapse: collapse;
	background-color:lightblue;
	
}


h1 {
	color:lightblue;
	text-align:left;
	font-family: "vivaldi";
	font-size:60px;
}
	
</style>

<div class="container">
	<h1>Reservation</h1>
	<div class="row">
		<div class="col-sm-8">
			<table class="table table-hover">
				<tr>
					<th>Reservation ID</th>
					<th>Customer ID</th>
					<th>Asset ID</th>
					<th>Start Date</th>
					<th>End Date</th>
					<th>Status</th>
					<th>Agreement</th>
					
				</tr>
<?php
		$sql = "SELECT * FROM tb_reservation ";
		$result = selectData ($sql);
		while($row = $result->fetch_assoc()) {
			
				echo "	<tr>"	;
				echo "	<td>" .	$row["reservationID"] .	"</td>";
				echo "	<td>" .	$row["customerID"]	   .	"</td>";
				echo "	<td>" .	$row["assetID"]	   .	"</td>";
				echo "	<td>" .	$row["startDate"] 	   .	"</td>";
				echo "	<td>" .	$row["endDate"]	   .	"</td>";
				echo "	<td>" .	$row["status"]	   .	"</td>";
				echo "	<td>" .	$row["agreement"]  .	"</td>";
	
?>
		<form action="reservation.php" method="POST">
			<input type="hidden" name="reservationID" value = "<?php echo $row["reservationID"]; ?>">
			
			<td><input class="btn btn-success" type= "submit" name = "Print" value = "Print"></td>	
			<td><input class="btn btn-success" type= "submit" name = "Confirm" value = "Confirm" ></td>	
			<td><input class="btn btn-success" type= "submit" name = "Cancel" value = "Cancel"></td>	
		</tr>
		</form>
		<?php } 
		$conn->close();
		?>
			</table>
		</div>
		</div>
</div>
</div>

</body>
</html>