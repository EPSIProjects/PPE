<?php $title="Acceuil"; ?>
<?php include '../header.php'; ?>

 <form class="form-horizontal" role="form" method="POST" action="http://www.para-vent.franceserv.com/admin/traitement.php">
  <div class="form-group">
    <label class="control-label col-sm-2" for="text">Identifiant :</label>
    <div class="col-sm-10">
      <input type="text" class="form-control" id="text" placeholder="Entrer votre identifiant">
    </div>
  </div>
  <div class="form-group">
    <label class="control-label col-sm-2" for="pwd">Mot de passe :</label>
    <div class="col-sm-10">
      <input type="password" class="form-control" id="pwd" placeholder="Entrer votre mot de passe">
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