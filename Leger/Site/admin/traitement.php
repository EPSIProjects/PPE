<?php

session_start();
htmlentities('azéoràèndjùd', ENT_COMPAT, 'UTF-8');

include("../header.php");

$bdd = mysqli_connect("sql.franceserv.fr","paravent","paravent1234","darkmath_db2");

if ($_SERVER["REQUEST_METHOD"] == "POST") {
	$username = mysqli_real_escape_string($bdd, $_POST['user']);
	$password = mysqli_real_escape_string($bdd, $_POST['password']);
}
if ($_SERVER["REQUEST_METHOD"] != "POST") {
	$username = $_SESSION['login_user'];
	$password = $_SESSION['password_user'];
}

$sql_query = "SELECT * FROM personnel WHERE identifiant_personnel=\"".$username."\" AND mot_de_passe_personnel=\"".$password."\"";
$result = mysqli_query($bdd, $sql_query);
$row = mysqli_fetch_array($result, MYSQLI_ASSOC);
$count = mysqli_num_rows($result);

if ($count == 1) {
	if ($_SERVER["REQUEST_METHOD"] == "POST") {
		$_SESSION['login_user'] = $username;
		$_SESSION['password_user'] = $password;
	}
}

echo "ok";



include '../footer.php';
?>