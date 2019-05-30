var health : float = 10;
var playerController : GameObject;

function OnTriggerStay(collision: Collider) {
   
    if (collision.gameObject.tag == "Arma"){
        health -= 0.1f;
        
    }
}

    function Update()
    {
        if(health <= 0f)
        {
            Destroy(gameObject);
        }
    }
