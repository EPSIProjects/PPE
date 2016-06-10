<?php $title="Administration"; ?>
<?php include '../header.php'; ?>

 <form class="form-horizontal formadmin" role="form" action="traitement.php" method="POST">
  <div class="form-group">
    <label class="control-label col-sm-2" for="text">Identifiant :</label>
    <div class="col-sm-5">
      <input type="text" class="form-control" id="user" name="user" placeholder="Entrer votre identifiant">
    </div>
  </div>
  <div class="form-group">
    <label class="control-label col-sm-2" for="pwd">Mot de passe :</label>
    <div class="col-sm-5">
      <input type="password" class="form-control" id="password" name="password" placeholder="Entrer votre mot de passe">
    </div>
  </div>
  <div class="form-group">
    <div class="col-sm-offset-2 col-sm-10">
      <div class="checkbox">
        <label><input type="checkbox"> Se souvenir de moi</label>
      </div>
    </div>
  </div>
  <div class="form-group">
    <div class="col-sm-offset-2 col-sm-10">
      <button type="submit" class="btn btn-default">Valider</button>
    </div>
  </div>
</form>
<br>


<?php include '../footer.php'; ?>