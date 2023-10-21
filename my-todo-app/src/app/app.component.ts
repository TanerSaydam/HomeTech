import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: "./app.component.html"
})
export class AppComponent {
  //ters tırnak ctrl+alt+enter tuşunun yanındaki virgül işaretiyle yapılıyor
  //degiskenAdi: tipi = "default değeri";
  //CRUD Create Read update Deletea


  constructor(
    private http: HttpClient
  ){
    this.getAll();
  }


  getAll(){
    this.http.get<string[]>("https://localhost:7065/api/values/GetAll").subscribe(res=> {
      this.todos = res;
    })
  }
  search: string = "";
  name: string = "Taner Saydam";
  work: string = "";
  todos: string[] = [];
  updateWork: string = "";
  updateIndex: number = 0;
  isUpdateFormActive: boolean = false;
  
  get(index: number){
    this.updateWork = this.todos[index];
    this.updateIndex = index
    this.isUpdateFormActive = true;
  }

  update(){
    this.http.get("https://localhost:7065/api/values/Update/" + this.updateIndex + "/" + this.updateWork).subscribe(res=> {
      this.getAll();
      this.isUpdateFormActive = false;
    })
   
  }

  removeByIndex(index: number){
    const response = confirm("Kaydı silmek istiyor musunuz?");
    if(response){
      this.http.get("https://localhost:7065/api/values/RemoveByIndex/" + index).subscribe(res=> {
      this.getAll();
    })
    }
  }

  save(){
    this.http.get("https://localhost:7065/api/values/Create/" + this.work).subscribe(res=> {
      this.getAll();
      this.work = "";
    })
  }
}
