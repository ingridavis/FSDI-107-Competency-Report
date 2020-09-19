

function fetchTasks(){
    // create a get Ajax request to /api/tasks
    //console.log the reponse from the server
     $.ajax({
            url: '/api/tasks',
            type: 'GET',
            success: res=>{
                console.log(res);
                for (let i=0; i<res.length; i++){
                    displayTask(res[i]);
                }
            },
            error: details =>{
                console.log("error", details);
            }
           
        });
}

function displayTask(task){ 
    var container = $("#tasks");

    var syntax = `
    <div class='task'>
        <div class="circle-with-task">
            <i class="far fa-circle check"></i>
            <div class='task-content'>
                <h5 class='task-title'>${task.title}</h5>
                <label class='task-notes'>${task.notes}</label> 
            </div>

        </div>
        
        
        
        <div><i class='fas fa-star important'></i></div>
        
    </div>
    
    `;

    container.append(syntax);
}

function register(){
    // get values from the form
    let title = $("#txtTitle").val();
    let notes = $("#txtNotes").val();
    let imp = $("#chkImportant").is(":checked");

    
    // validation
    if(title.length < 5){
        alert("Please verify the name of the task");
        return; // no code will be extcuted, code returns out of the function

    }

    // create an object

    let task = { 
        title: title,
        notes: notes,
        important: imp,
    };
    console.log(task);

    // send the object to the backend
    $.ajax({
        type: 'POST',
        url: '/api/CreateTask',
        data: JSON.stringify(task),
        contentType: 'application/json',
        success: res => {
            console.log("Server says", res);
            displayTask(res); // option 1: get all tasks and render them again

            

            
        },
        error: details => {
            console.log("Error", details);
        }
    });
    // clear form
}

function init(){
    console.log("MyCalendar Page");

    // Set up hook events SESSION 4
    $("#btnSave").click(register);

    fetchTasks();
}

window.onload =init;