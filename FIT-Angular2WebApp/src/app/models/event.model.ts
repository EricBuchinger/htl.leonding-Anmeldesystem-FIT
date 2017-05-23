import {EntityObject} from "./entityObject";
export interface Event extends EntityObject{

date:Date;
registrationStart:Date;
registrationEnd:Date;
isLocked:boolean;
}
