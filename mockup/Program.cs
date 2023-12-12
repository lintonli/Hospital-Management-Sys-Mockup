/*
//using mockup.Service;

//PatientServices patientService = new PatientServices();

//// Create
//patientService.AddPatient("Linton");

//// Read
//var patient = patientService.GetPatient(1);
//Console.WriteLine($"Patient: {patient?.FirstName}");

//// Update
//patientService.UpdatePatient(1, "Jane");

//// Delete
//patientService.DeletePatient(1);


using mockup.Service;

PatientServices patientService = new PatientServices();

// Create
patientService.AddPatient("Linton");

// Read
var patient = patientService.GetPatient(1);
Console.WriteLine($"Patient: {patient?.FirstName}");

// Update
patientService.UpdatePatient(1, "Jane");

// Delete
patientService.DeletePatient(1);*/
/*
using mockup.Service;
using mockup.EntityModel;

AppointmentServices services = new AppointmentServices();


var appointment = services.AddAppointment(new Appointment()
{
    AppointmentDate = DateOnly.FromDateTime(DateTime.Now),
    AppointmentTime = TimeOnly.FromDateTime(DateTime.Now), 
    Doctor = new Doctor() { DoctorName="Linton", Speciality="NeuroSurgery"},
    Patient = new Patient() { 
        FirstName="Brian",
        LastName ="gAKURE",
        Email = "BRIAN@DUMMY.COM",
        Room = new Room () { RoomNumber="01", RoomType="Ward"}
    }
});

Console.WriteLine(appointment);*/

/*using mockup.Controllers;

PatientsControllers patientsControllers = new PatientsControllers();
patientsControllers.Init();*/
/*
using mockup.Controllers;

RoomControllers roomControllers = new RoomControllers();
roomControllers.init();*/

/*using mockup.Controllers;

DoctorControllers doctorControllers = new DoctorControllers();
doctorControllers.init();*/
using mockup.Controllers;
AppointmentControllers appointmentControllers = new AppointmentControllers();
DoctorControllers doctorControllers = new DoctorControllers();
PatientsControllers patientsControllers = new PatientsControllers();

bool logic = true;
while (logic)
{
    Console.WriteLine("Welcome to our Hospital Management System");
    Console.WriteLine("1. Manage Patients");
    Console.WriteLine("2. Manage Appointments");
    Console.WriteLine("3. Manage Doctors");
    Console.WriteLine("4. Exit");
    var input = Console.ReadLine();
    switch(input)
    {
        case "1": ManagePatients();
            break;
        case "2": ManageAppointment();
            break;
        case "3": ManageDoctors();
            break;
        case "4":
            logic = false;
            break;
        default:
            Console.WriteLine("Invalid input choice");
            break;
    }
}

void ManageDoctors()
{
    DoctorControllers doctorControllers = new DoctorControllers();
    doctorControllers.duc();
}

void ManageAppointment()
{
    AppointmentControllers appointmentControllers = new AppointmentControllers();
    appointmentControllers.app();
}


void ManagePatients()
{
    PatientsControllers patientControllers = new PatientsControllers();
    patientControllers.Init();
}