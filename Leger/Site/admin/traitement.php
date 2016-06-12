<?php
$title="Panel d'administration";

htmlentities('azéoràèndjùd', ENT_COMPAT, 'UTF-8');

include("../header.php");

    include '../connexion.php'; 
	$username = mysqli_real_escape_string($bdd, $_POST['user']);
	$password = mysqli_real_escape_string($bdd, $_POST['password']);


$sql_query = "SELECT * FROM personnel WHERE identifiant_personnel=\"".$username."\" AND mot_de_passe_personnel=\"".$password."\"";
$result = mysqli_query($bdd, $sql_query);
$row = mysqli_fetch_array($result, MYSQLI_ASSOC);
$count = mysqli_num_rows($result);

if ($count == 1) {
	
	$sql_query2 = "SELECT * FROM formation";
	$result2 = mysqli_query($bdd, $sql_query2);

	echo ('<form method="post" action="modifforma.php">
			<div class="row">
			<div class="table-responsive col-md-12">
				<table class="table-bordered TabCel col-md-12">
					<thead>
						<tr>
							<td class="Marg"><h4>Libellé formation</h4></td>
							<td class="Marg"><h4>Code formation</h4></td>
							<td class="Marg"><h4>Nom formateur</h4></td>
							<td class="Marg"><h4>Date de début</h4></td>
							<td class="Marg"><h4>Date de fin</h4></td>
						</tr>
					</thead>');
	$i=0;
	while ($data = mysqli_fetch_assoc($result2)) {

		echo('<tbody>
					<tr>
						<td class="Col1 Marg"> <input class="form-control LibForm" type="text" name="lbforma" value="'.$data['libelle_formation'].'"></td>
						<td class="Col2 Marg"> <input class="form-control" type="text" name="Code-formation" value="'.$data['code_formation'].'"</td>
						<td class="Col3 Marg"> <select id="mySelect'.$i.'">');
						$sql_query_formateur = "SELECT id_personnel, nom_personnel FROM personnel WHERE fonction_personnel = 'F'";
						$result3 = mysqli_query($bdd, $sql_query_formateur);
						while ($formateur = mysqli_fetch_assoc($result3)) {
							echo ('<option value="'.$formateur['id_personnel'].'">'.$formateur['nom_personnel'].'</option>');
						}
						echo ('</select> </td>
							<script>
    							document.getElementById("mySelect'.$i.'").value = "'.$data['id_personnel_formation'].'";
							</script>
						<td class="Col4 Marg"> '.$data['date_debut_formation'].' </td>
						<td class="Col5 Marg"> '.$data['date_fin_formation'].' </td>
					</tr>
				</tbody>');
						$i++;
	}
	echo ('	</table>
		
			</div>
		    </div>
		    <br>
			<input type="submit" value="Envoyer" class="btn btn-success">
		    </form>');
	echo('<br>
		<br>
		<br>');

	$sql_query4 = "SELECT * FROM article";
	$result4 = mysqli_query($bdd, $sql_query4);

	echo ('<form method="post" action="modifArticle.php">
			<div class="row">
			<div class="table-responsive col-md-12">
				<table class="table-bordered TabCel col-md-12">
					<thead>
						<tr>
							<td class="Marg"><h4>Libellé article</h4></td>
							<td class="Marg"><h4>Stock article</h4></td>
							<td class="Marg"><h4>Nom fournisseur</h4></td>
							<td class="Marg"><h4>Prix</h4></td>
						</tr>
					</thead>');
	$i=0;
	while ($data = mysqli_fetch_assoc($result4)) {

		echo('<tbody>
					<tr>
						<td class="Col1 Marg"> <input class="form-control LibArticle" type="text" name="lbArticle" value="'.$data['libelle_article'].'"></td>
						<td class="Col2 Marg"> <input class="form-control" type="text" name="stkArticle" value="'.$data['stock_article'].'"</td>
						<td class="Col3 Marg"> <select id="mySelect'.$i.'">');
						$sql_query_fournisseur = "SELECT id_fournisseur, nom_fournisseur FROM fournisseur";
						$result5 = mysqli_query($bdd, $sql_query_fournisseur);
						while ($fournisseur = mysqli_fetch_assoc($result5)) {
							echo ('<option value="'.$fournisseur['id_fournisseur'].'">'.$fournisseur['nom_fournisseur'].'</option>');
						}
						echo ('</select> </td>
							<script>
    							document.getElementById("mySelect2'.$i.'").value = "'.$data['id_fournisseur_article'].'";
							</script>
						<td class="Col4 Marg"> <input class="form-control" type="text" name = "pxArticle" value="'.$data['prix_article'].'"</td>
					</tr>
				</tbody>');
						$i++;
	}
	echo ('	</table>
		
			</div>
		    </div>
		    <br>
			<input type="submit" value="Valider" class="btn btn-success">
		    </form>');
}
else {
	echo "Erreur de connexion";
}




include '../footer.php';
?>