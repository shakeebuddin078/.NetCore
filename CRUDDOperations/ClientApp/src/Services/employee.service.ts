import { HttpClient } from "@angular/common/http";
import { Inject } from "@angular/core";
import { Observable } from "rxjs";

export class EmployeeService {
  aapurl: string = "";
  constructor(private httpobj: HttpClient, @Inject('BASE_URL') _baseurl: string) {
    this.aapurl = _baseurl;
  }

  getallEmployee(): Observable<EmployeeDataModel>{
    return this.httpobj.get<EmployeeDataModel>(this.aapurl= "api/Employee/Index");
  }


}
  export class EmployeeDataModel {
    empid: number;
    name: string;
    gender: string;
    city: string;
    department: string;
}
