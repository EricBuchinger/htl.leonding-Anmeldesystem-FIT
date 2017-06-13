import {EntityObject} from "./entityObject";
export class Event extends EntityObject{

constructor(public id:number,
            public timestamp:string,
            public date:Date,
            public registrationStart:Date,
            public registrationEnd:Date,
            public isLocked:boolean){
  super(id,timestamp);
}
}
