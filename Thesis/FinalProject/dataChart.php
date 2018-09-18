<?php
//setting header to json
//header('Content-Type: application/json');

require ('Controller/db.php');
//query to get data from the table
$query = sprintf("SELECT col_dateofpurchase as date,col_totalprice as sales FROM tbl_transaction GROUP by col_dateofpurchase ORDER BY col_dateofpurchase ASC");

if ( isset( $_POST['submit'] ) )
{
	$fromdate  = $_POST["fromdate"];
	$todate = $_POST["todate"];
	$query = sprintf("SELECT col_dateofpurchase as date,col_totalprice as sales 
	FROM tbl_transaction 
	WHERE date(col_dateofpurchase) between date('$fromdate') and date('$todate')
	GROUP by col_dateofpurchase ORDER BY col_dateofpurchase ASC");
	//echo $query;
	//echo "from: " . $fromdate . "to: " . $todate;
}

//execute query
$result = mysqli_query($db, $query);

//loop through the returned data
$data = array();
foreach ($result as $row) {
	$data[] = $row;
}

//now print the data
//print json_encode($data);
?>

<script type="text/javascript">
// pass PHP variable declared above to JavaScript variable
var data = <?php echo json_encode($data) ?>;
</script>



