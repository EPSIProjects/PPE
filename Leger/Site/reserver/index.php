<?php $title="Réserver une formation"; ?>
<?php include '../header.php'; ?>

 <form method="POST" action="../reserver/envoi.php" name="monform">
  <div class="form-group">
<select>
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
    <label for="msg">Message :</label>
    <textarea class="form-control" id="msg" name="message"></textarea>
  </div>
<br><div id="bouttons">
  <button type="submit" class="btn btn-default">Envoyer</button>&nbsp;<button type="reset" class="btn btn-default">Effacer</button>
  </div>
</form>
<?php include '../footer.php'; ?>