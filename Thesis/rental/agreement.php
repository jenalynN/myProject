<?php 
	include 'db.php';
	include 'functions.php'; 
	include 'header.php';
?>
<?php 
	
	
	//echo '<pre>';
	//var_dump( $data );
	//echo '</pre>';
?>

<?php 
if (!empty($_POST["submit"])){
	$date = $_POST["bday"];
	$reservation = array("customerID"=>"2", "assetID"=>"2", "startDate"=>$date, "endDate"=>$date);
	setcookie('myReservation', json_encode($reservation), time()+3600);
	$data = json_decode($_COOKIE['myReservation'], true);
	
	$sql = "INSERT INTO tb_reservation(customerID,
	assetID,
	startDate,
	endDate,status,agreement)
	values('{$data["customerID"]}',
	'{$data["assetID"]}',
	'{$data["startDate"]}',
	'{$data["endDate"]}',
	'Pending',true)";
	insertData($sql);
	
}

$conn->close();
?>

<div class="container"> 
	<div class="row">
	<div class="col-sm-6">
			<h1>Agreement</h1><hr>				
		
			<p align="justify">
				Lorem ipsum dolor sit amet, veniam numquam has te. No suas nonumes recusabo mea, est ut graeci definitiones. His ne melius vituperata scriptorem, cum paulo copiosae conclusionemque at. Facer inermis ius in, ad brute nominati referrentur vis. Dicat erant sit ex. Phaedrum imperdiet scribentur vix no, ad latine similique forensibus vel.
				Dolore populo vivendum vis eu, mei quaestio liberavisse ex. Electram necessitatibus ut vel, quo at probatus oportere, molestie conclusionemque pri cu. Brute augue tincidunt vim id, ne munere fierent rationibus mei. Ut pro volutpat praesent qualisque, an iisque scripta intellegebat eam.
				Mea ea nonumy labores lobortis, duo quaestio antiopam inimicus et. Ea natum solet iisque quo, prodesset mnesarchum ne vim. Sonet detraxit temporibus no has. Omnium blandit in vim, mea at omnium oblique.
				Eum ea quidam oportere imperdiet, facer oportere vituperatoribus eu vix, mea ei iisque legendos hendrerit. Blandit comprehensam eu his, ad eros veniam ridens eum. Id odio lobortis elaboraret pro. Vix te fabulas partiendo.
				Natum oportere et qui, vis graeco tincidunt instructior an, autem elitr noster per et. Mea eu mundi qualisque. Quo nemore nusquam vituperata et, mea ut abhorreant deseruisse, cu nostrud postulant dissentias qui. Postea tincidunt vel eu.
				Ad eos alia inermis nominavi, eum nibh docendi definitionem no. Ius eu stet mucius nonumes, no mea facilis philosophia necessitatibus. Te eam vidit iisque legendos, vero meliore deserunt ius ea. An qui inimicus inciderint.
			</p>
			
			<form class="form-horizontal" action="agreement.php" method="POST">
				<div class="form-group">
					<div class="col-xs-6 ">
						<div class="checkbox">
							<label>
								<input type="checkbox" name="agree" value="agree" /> Agree with the terms and conditions
							</label>
						</div>
					</div>
				</div>

				<div class="form-group" >
					<div class="col-xs-6 ">
						<input type="date" name="bday" min="1979-12-31">
						<button type="submit" class="btn btn-primary" name="submit" value="submit">Submit</button>						
					</div>
				</div>	
			</form>
		</div>
		<div class="col-sm-6">
			<div class="panel-group">
				<div class="panel panel-primary">
					<div class="panel-heading"> 
						<h1 class="panel-title text-center">Customer Information</h1>
					</div>
					<div class="panel-body">
						<table class="table">
						<tr>
							<td>Name</td>
							<td>Jenalyn Naldoza</td>
						</tr>
						<tr>
							<td>Address:</td>
							<td>P. Rodriguez, Capitol Site, Cebu</td>
						</tr>
						<tr>
							<td>Contact No.:</td>
							<td>09958223666</td>
						</tr>
						<tr>
							<td>Email:</td>
							<td>july@example.com</td>
						</tr>
						</table>
					</div>
				</div>
			</div>
			
			<div class="panel-group">
				<div class="panel panel-primary">
					<div class="panel-heading"> 
						<h1 class="panel-title text-center">Reservation Summary</h1>
					</div>
					<div class="panel-body">						
						<table class="table">
							<tr>
								<td>House No.:</td>
								<td>201</td>
							</tr>
							<tr>
								<td>House Name:</td>
								<td>Casa Maria</td>
							</tr>
							<tr>
								<td>Bed Room</td>
								<td>Bath Room</td>
								<td>Area</td>
							</tr>
							<tr>
								<td>3</td>
								<td>2</td>
								<td>40 sqm.</td>
							</tr>
							<tr>
								<td>Rate:</td>
								<td>₱ 2000</td>
							</tr>
						</table>
					</div>
				</div>
			</div>
			
				
				
		</div>
	</div>
</div>
</body>
</html>