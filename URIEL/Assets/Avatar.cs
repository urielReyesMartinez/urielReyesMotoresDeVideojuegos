using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Avatar : MonoBehaviour
{
    public int AvatarIndex = 0;
    public List<Avataratributes> Avatars;
    public TMP_Text Name;
    public TMP_Text desc;
    public TMP_Text xp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Name.text = Avatar[AvatarIndex].name;
        desc.text = "information"+Avatar[AvatarIndex].descripcion;
        xp.text = Avatar[AvatarIndex].xp.Tosting() + "xp";
    }
}
