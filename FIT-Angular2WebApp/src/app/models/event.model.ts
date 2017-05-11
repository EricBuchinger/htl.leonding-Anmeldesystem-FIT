import {EntityObject} from "./entityObject";
export interface Event extends EntityObject{

date:string;
registrationStart:string;
registrationEnd:string;
isLocked:boolean;
}
