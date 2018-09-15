<?php

 
//$sql = "INSERT INTO t_customer (name, email)
//VALUES ('John Doe', 'john@example.com')";
//insertData($sql);
function insertData ($sql) {
	if ($GLOBALS['conn']->query($sql) === TRUE) {
		//echo "New record created successfully";
	} else {
		echo "Error: " . $sql . "<br>" . $GLOBALS['conn']->error;
	}
}

//$sql = "UPDATE t_customer SET name='Doe' WHERE id=1";
//updateData($sql);
function updateData ($sql) {
	if ($GLOBALS['conn']->query($sql) === TRUE) {
		//echo "Record updated successfully";
	} else {
		echo "Error updating record: " . $GLOBALS['conn']->error;
	}
}

//$sql = "DELETE FROM t_customer WHERE id=1";
//deleteData ($sql);
function deleteData ($sql) {
	if ($GLOBALS['conn']->query($sql) === TRUE) {
		//echo "Record deleted successfully";
	} else {
		echo "Error deleting record: " . $GLOBALS['conn']->error;
	}
}

//$sql = "SELECT * FROM t_customer";
//$result = selectData ($sql);
function selectData ($sql) {
	$result = $GLOBALS['conn']->query($sql);
	if ($result->num_rows > 0) {
		return $result;
	} else {
		//echo "0 results";
	}
	return $result;
}


?>