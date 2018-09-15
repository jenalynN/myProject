<?php
//setting header to json
header('Content-Type: application/json');

require ('Controller/db.php');
	
//query to get data from the table
$query = sprintf("SELECT col_dateofpurchase as date,col_totalprice as sales FROM tbl_transaction GROUP by col_dateofpurchase ORDER BY col_dateofpurchase ASC");

//execute query
$result = mysqli_query($db, $query);

//loop through the returned data
$data = array();
foreach ($result as $row) {
	$data[] = $row;
}

//now print the data
print json_encode($data);
?>
