import { NgModule } from '@angular/core';
import { BrowserModule  } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AreaTrabalhoModule } from './area-trabalho/area-trabalho.module';
import { MedicoService } from './medico/medico.service';
import { EspecialidadeService } from './especialidade/especialidade.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    AreaTrabalhoModule
  ],
  providers: [MedicoService, EspecialidadeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
