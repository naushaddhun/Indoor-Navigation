using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerNavigation : MonoBehaviour
{

    private NavMeshAgent navAgent;
    public Dropdown dd;



    public GameObject HOD1styr;
    public GameObject Maths;
    public GameObject EMLab;
    public GameObject Chemlab;
    public GameObject BoysWash1styr;
    public GameObject Medical;
    public GameObject Girlswash;
    public GameObject MBA1st;
    public GameObject HODelec;
    public GameObject MBA2nd;
    public GameObject EELab;
    public GameObject SeminarHall;
    public GameObject BoyswashMBA;

    public GameObject Fsec1styr;
    public GameObject Studentsec;
    public GameObject StaffWashAdmin;
    public GameObject DeanAcademics;
    public GameObject Principal;
    public GameObject CEO;
    public GameObject IIIcell;
    public GameObject Admin;
    public GameObject DeanAdmin;
    public GameObject Accountsec;
    public GameObject MechanicsLab;
    public GameObject E001;
    public GameObject ETCStaffRoom;

    public GameObject ETCHOD;
    public GameObject ETCStaffWash;
    public GameObject ETCStaff2;
    public GameObject ETClab1;
    public GameObject ETCLab2;
    public GameObject ETCLab3;
    public GameObject ETCCentalLab;
    public GameObject E003;
    public GameObject MechLab1;
    public GameObject BoysWashCSE;
    public GameObject MechProjectLab;
    public GameObject ServerRoom;
    public GameObject CNLab;

    public GameObject M101;
    public GameObject GirlsWashCSE;
    public GameObject TutorialRoom;
    public GameObject ITProjectLab;
    public GameObject M103;
    public GameObject StaffWashCSE;
    public GameObject DevendraSir;
    public GameObject HODSirCSE;
    public GameObject SwapniliMaam;
    public GameObject CSEStaffRoom;
    public GameObject RamSirCabin;
    public GameObject DPLab;
    public GameObject M105;
    public GameObject RnD;
    public GameObject Lab3;
    public GameObject E101;




    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }


    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      

        switch (dd.value)
        {
            case 1:
                navAgent.SetDestination(HOD1styr.transform.position);
                break;

            case 2:
                navAgent.SetDestination(MechanicsLab.transform.position);
                break;

            case 3:
                navAgent.SetDestination(Fsec1styr.transform.position);
                break;

            case 4:
                navAgent.SetDestination(Studentsec.transform.position);
                break;

            case 5:
                navAgent.SetDestination(Accountsec.transform.position);
                break;

            case 6:
                navAgent.SetDestination(StaffWashAdmin.transform.position);
                break;

            case 7:
                navAgent.SetDestination(DeanAcademics.transform.position);
                break;

            case 8:
                navAgent.SetDestination(Principal.transform.position);
                break;

            case 9:
                navAgent.SetDestination(DeanAdmin.transform.position);
                break;

            case 10:
                navAgent.SetDestination(CEO.transform.position);
                break;

            case 11:
                navAgent.SetDestination(Admin.transform.position);
                break;

            case 12:
                navAgent.SetDestination(IIIcell.transform.position);
                break;

            case 13:
                navAgent.SetDestination(Maths.transform.position);
                break;

            case 14:
                navAgent.SetDestination(EMLab.transform.position);
                break;

            case 15:
                navAgent.SetDestination(Chemlab.transform.position);
                break;

            case 16:
                navAgent.SetDestination(BoysWash1styr.transform.position);
                break;

            case 17:
                navAgent.SetDestination(E001.transform.position);
                break;

            case 18:
                navAgent.SetDestination(ETCStaffRoom.transform.position);
                break;

            case 19:
                navAgent.SetDestination(ETCHOD.transform.position);
                break;

            case 20:
                navAgent.SetDestination(ETCStaffWash.transform.position);
                break;

            case 21:
                navAgent.SetDestination(ETCStaff2.transform.position);
                break;

            case 22:
                navAgent.SetDestination(ETClab1.transform.position);
                break;

            case 23:
                navAgent.SetDestination(ETCLab2.transform.position);
                break;

            case 24:
                navAgent.SetDestination(ETCLab3.transform.position);
                break;

            case 25:
                navAgent.SetDestination(E003.transform.position);
                break;

            case 26:
                navAgent.SetDestination(ETCCentalLab.transform.position);
                break;

            case 27:
                navAgent.SetDestination(Medical.transform.position);
                break;

            case 28:
                navAgent.SetDestination(Girlswash.transform.position);
                break;

            case 29:
                navAgent.SetDestination(BoyswashMBA.transform.position);
                break;

            case 30:
                navAgent.SetDestination(MBA2nd.transform.position);
                break;

            case 31:
                navAgent.SetDestination(HODelec.transform.position);
                break;

            case 32:
                navAgent.SetDestination(MBA1st.transform.position);
                break;

            case 33:
                navAgent.SetDestination(EELab.transform.position);
                break;

            case 34:
                navAgent.SetDestination(SeminarHall.transform.position);
                break;

            case 35:
                navAgent.SetDestination(MechLab1.transform.position);
                break;

            case 36:
                navAgent.SetDestination(BoysWashCSE.transform.position);
                break;

            case 37:
                navAgent.SetDestination(MechProjectLab.transform.position);
                break;

            case 38:
                navAgent.SetDestination(ServerRoom.transform.position);
                break;

            case 39:
                navAgent.SetDestination(CNLab.transform.position);
                break;

            case 40:
                navAgent.SetDestination(M101.transform.position);
                break;

            case 41:
                navAgent.SetDestination(GirlsWashCSE.transform.position);
                break;

            case 42:
                navAgent.SetDestination(TutorialRoom.transform.position);
                break;

            case 43:
                navAgent.SetDestination(ITProjectLab.transform.position);
                break;

            case 44:
                navAgent.SetDestination(M103.transform.position);
                break;

            case 45:
                navAgent.SetDestination(StaffWashCSE.transform.position);
                break;

            case 46:
                navAgent.SetDestination(DevendraSir.transform.position);
                break;

            case 47:
                navAgent.SetDestination(HODSirCSE.transform.position);
                break;

            case 48:
                navAgent.SetDestination(SwapniliMaam.transform.position);
                break;

            case 49:
                navAgent.SetDestination(CSEStaffRoom.transform.position);
                break;

            case 50:
                navAgent.SetDestination(RamSirCabin.transform.position);
                break;

            case 51:
                navAgent.SetDestination(DPLab.transform.position);
                break;

            case 52:
                navAgent.SetDestination(M105.transform.position);
                break;

            case 53:
                navAgent.SetDestination(RnD.transform.position);
                break;

            case 54:
                navAgent.SetDestination(Lab3.transform.position);
                break;

            case 55:
                navAgent.SetDestination(E101.transform.position);
                break;



            default:
                break;
        }



    }
  
}
