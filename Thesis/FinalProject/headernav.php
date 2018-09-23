<header class="main-header">
	<!-- Logo -->
	<a href="data.php" class="logo">
	  <!-- mini logo for sidebar mini 50x50 pixels -->
	  <span class="logo-mini">PCS</span>
	  <!-- logo for regular state and mobile devices -->
	  <span class="logo-lg">Posh Concept Store </span>
	</a>
	<!-- Header Navbar: style can be found in header.less -->
	<nav class="navbar navbar-static-top" role="navigation">
	  <!-- Sidebar toggle button-->
	  <a href="#" class="sidebar-toggle" data-toggle="offcanvas" role="button">
		<span class="sr-only">Toggle navigation</span>
	   
	  </a>
	  <div class="navbar-custom-menu">
		<ul class="nav navbar-nav">
		  <!-- Messages: style can be found in dropdown.less-->
		  
					
		  <!-- Notifications: style can be found in dropdown.less -->
		 
		  <!-- User Account: style can be found in dropdown.less -->
		  <li class="dropdown user user-menu">
			<a href="#" class="dropdown-toggle" data-toggle="dropdown">
			  <span class="hidden-xs"><?php echo $_SESSION['user'] ?></span>
			</a>
			<ul class="dropdown-menu">
			  <!-- User image -->
			  
			  <!-- Menu Body -->
			  
			  <!-- Menu Footer-->
			  <li class="user-footer">
				<div class="pull-left">
				  <a href="#" class="btn btn-default btn-flat">Profile</a>
				</div>
				<div class="pull-right">
				  <a href="controller/session_destroy.php" class="btn btn-default btn-flat">Sign out</a>
				</div>
			  </li>
			  
			</ul>
		  </li>
		  <!-- Control Sidebar Toggle Button -->
		 
		</ul>
	  </div>
	</nav>
  </header>
  
  

	  <!-- Sidebar user panel -->
	 
	  <!-- search form -->
	  <aside class="main-sidebar">
	<!-- sidebar: style can be found in sidebar.less -->
	<section class="sidebar" style="height: auto;">
	  
	  <ul class="sidebar-menu">
	  <li>
	   <a href="Dashboard.php">
			<i class="fa fa-pie-chart"></i>
			<span>Dashboard</span>
			
		  </a>
		  </li>
		<li>
		  <a href="sales.php">
			<i class="fa fa-cart-arrow-down"></i> <span>Sales</span> 
		  </a>
		</li>
		<li class="treeview">
		  <a href="#">
			<i class="fa fa-pie-chart"></i>
			<span>Graphs</span>
			<i class="fa fa-angle-left pull-right"></i>
		  </a>
		  <ul class="treeview-menu">
			<li><a href="barchart.php"><i class="fa fa-circle-o"></i> Bar Graph</a></li>
			<!-- li><a href="barchart.php"><i class="fa fa-circle-o"></i> Bar Graphs</a></li -->
		  </ul>
		</li>
		<?php 
			if($_SESSION['user'] == "admin"){
		?>
		<li class="treeview">
		  <a href="#">
			<i class="fa fa-user"></i>
			<span>User Accounts</span>
			<i class="fa fa-angle-left pull-right"></i>
		  </a>
		  <ul class="treeview-menu">
			<li><a href="userCashier.php"><i class="fa fa-circle-o"></i> Cashier</a></li>
			<li><a href="userBrandpartner.php"><i class="fa fa-circle-o"></i> Brand Partners</a></li>
		  </ul>
		</li>
		<?php } ?>
		<li class="treeview">
		  <a href="#">
			<i class="fa fa-th"></i> <span>Products</span>
			<i class="fa fa-angle-left pull-right"></i>
		  </a>
		  <ul class="treeview-menu">
			<li><a href="damage.php"><i class="fa fa-circle-o"></i> Damage</a></li>
			<!-- li><a href="../forms/advanced.html"><i class="fa fa-circle-o"></i> Fix</a></li -->
		  </ul>
		</li>
	   
	 
	</section>
	<!-- /.sidebar -->
		</ul>
  </aside>
  <!-- Add the sidebar's background. This div must be placed
	   immediately after the control sidebar -->
	   