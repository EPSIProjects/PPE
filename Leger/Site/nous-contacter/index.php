<?php $title="Contact"; ?>
<?php include '../header.php'; ?>
      <script type="text/javascript">
            document.getElementById("contact").className = "active";
      </script>
      
          <form class="reservform" method="POST" action="../nous-contacter/envoi.php" name="monform">
  <div class="form-group">
    <label for="nom">Nom et prénom :</label>
    <input type="text" class="form-control" id="nom" name="nom">
  </div>
  <div class="form-group">
    <label for="email">Courriel :</label>
    <input type="email" class="form-control" id="email" name="mail">
  </div>
  <div class="form-group">
    <label for="msg">Message :</label>
    <textarea class="form-control" id="msg" name="message"></textarea>
  </div>
<br><div id="bouttons">
  <button type="submit" class="btn btn-default buttoncenter">Envoyer</button>&nbsp;<button type="reset" class="btn btn-default">Effacer</button>
  </div>
</form>

<?php include '../footer.php'; ?>