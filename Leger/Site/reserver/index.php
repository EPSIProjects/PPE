<?php $title="Réserver une formation"; ?>
<?php include '../header.php'; ?>
<?php include '../connexion.php'; ?>

 <form id="reservform" method="POST" action="../reserver/envoie.php" name="monform">
  <div class="form-group">
    <label for="select">Type de formation souhaitée : </label>
<select name="type">
  <option value="Parachute">Parachute</option>
  <option value="Parapente">Parapente</option>
  <option value="Winsuit">Winsuit</option>
</select>
<br>
<br>
    <label for="nom">Nom et prénom :</label>
    <input type="text" class="form-control" id="nom" name="nom">
  </div>
  <div class="form-group">
    <label for="email">Email :</label>
    <input type="email" class="form-control" id="email" name="mail">
  </div>
    <div class="form-group">
    <label for="telephone">Téléphone :</label>
    <input type="tel" class="form-control" id="tel" name="tel">
  </div>
  <label for="periode">Période souhaitée :</label><br>
  <?php 
        $query = 'select id_formation, DATE_FORMAT(date_debut_formation, "%d/%m/%Y") AS dated, DATE_FORMAT(date_fin_formation, "%d/%m/%Y") AS datef from formation';
        $result = mysqli_query($bdd, $query);
echo '<select name="periode">';
            while ($donnees = mysqli_fetch_array($result, MYSQLI_ASSOC)){
            	$dateentiere = $donnees ['dated'].' - '.$donnees ['datef'];
                echo'<option value="'.$dateentiere.'">'.$dateentiere.'</option>';
            }
 echo '</select>';
  ?>

  <div class="form-group">
  <br>
    <label for="msg">Message :</label>
    <textarea class="form-control" id="msg" name="message"></textarea>
  </div>
<br><div id="bouttons">
  <button type="submit" class="btn btn-default">Envoyer</button>&nbsp;<button type="reset" class="btn btn-default">Effacer</button>
  </div>
</form>
<?php include '../footer.php'; ?>