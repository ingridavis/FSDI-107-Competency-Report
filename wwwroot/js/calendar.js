

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
        <i class="far fa-circle check"></i>
        <div class='task-content'>
            <h5 class='task-title'>${task.title}</h5>
            <label class='task-notes'>${tasks.notes}</label> 
        </div>

    <i class='fas fa-star important'></i>
    </div>
    `;

    container.append(syntax);
}

function init(){
    console.log("MyCalendar Page  ");

    fetchTasks();
}

window.onload =init;