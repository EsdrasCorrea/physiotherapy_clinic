import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.scss']
})
export class ClientComponent implements OnInit {

  public clients: any;
  
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getClient();
  }

  public getClient(): void {
    this.http.get('https://localhost:7057/Clients').subscribe(
      response => this.clients = response,
      error => console.log(error)
    );    
  }

}
