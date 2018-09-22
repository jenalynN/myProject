<?php
//setting header to json
//header('Content-Type: application/json');

require ('Controller/db.php');
//query to get data from the table
$query = sprintf("SELECT col_dateofpurchase as date,col_totalprice as sales FROM tbl_transaction GROUP by col_dateofpurchase ORDER BY col_dateofpurchase ASC");
if(isset($_SESSION['userId']) && $_SESSION['usertype'] != '1'){
	$query = sprintf("SELECT t.col_dateofpurchase as date,t.col_totalprice as sales FROM tbl_transaction t
	inner join tbl_order o on o.col_transactionid = t.col_transactionid 
	inner join tbl_product p on o.col_productid = p.col_productid 
	inner join tbl_brandpartner b on b.col_useraccountsid = p.col_useraccountsid 
	where b.col_useraccountsid = " . $_SESSION['userId'] . 
	" GROUP by col_dateofpurchase 
	ORDER BY col_dateofpurchase ASC");
	//echo $query;
}
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
	
	if(isset($_SESSION['userId']) && $_SESSION['usertype'] != '1'){
	$query = sprintf("SELECT t.col_dateofpurchase as date,t.col_totalprice as sales FROM tbl_transaction t
	inner join tbl_order o on o.col_transactionid = t.col_transactionid 
	inner join tbl_product p on o.col_productid = p.col_productid 
	inner join tbl_brandpartner b on b.col_useraccountsid = p.col_useraccountsid 
	where b.col_useraccountsid = " . $_SESSION['userId'] . 
	" and date(col_dateofpurchase) between date('$fromdate') and date('$todate') 
	GROUP by col_dateofpurchase 
	ORDER BY col_dateofpurchase ASC");
	//echo $query;
	}
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



