import { Component, OnInit, EventEmitter, Output } from '@angular/core'

@Component({
    selector: 'app-toolbar',
    templateUrl: './toolbar.component.html',
    styleUrls: ['./toolbar.component.css']
})
export class ToolbarComponent implements OnInit {

    @Output()
    private filterChanged: EventEmitter<string>;

    public constructor() {
        this.filterChanged = new EventEmitter<string>();
    }

    ngOnInit(): void {
        
    }

    all(){
        this.filterChanged.emit("");
    }

    confirmed(){
        this.filterChanged.emit("confirmed");
    }

    abel(){
        this.filterChanged.emit("abel");
    }

    absEDVO(){
        
    }

    standOccupancy(){

    }

    workload(){

    }

    modification(){

    }

    media(){

    }

    administrativeData(){

    }

    csvExport() {

    }
}

