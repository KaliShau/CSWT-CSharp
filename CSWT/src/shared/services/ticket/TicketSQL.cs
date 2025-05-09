﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.db;

namespace CSWT.src.shared.services.ticket
{
    public class TicketSQL
    {
        public string CreateTicket = @"
            INSERT INTO Tickets 
            (title, description, client_id, priority_id, status_id) VALUES
            (@title, @description, @client_id, @priority_id, @status_id);
        ";

        public string UpdateTicketClient = @"
            UPDATE Tickets
            SET title = @title, description = @description
            WHERE ID = @ID;
        ";

        public string AssignedTicket = @"
            UPDATE Tickets
            SET assigned_to = @assigned_to, status_id = @status_id
            WHERE ID = @ID;
        ";

        public string DeleteTicket = @"
            BEGIN TRANSACTION;
    
            DELETE FROM Comments
            WHERE ticket_id = @ID;
    
            DELETE FROM Tickets
            WHERE ID = @ID;
    
            COMMIT;
        ";

        public string UpdateClosedAt = @"
            UPDATE Tickets
            SET closed_at = NOW()
            WHERE ID = @ID;
        ";

        public string UpdateTicket = @"
            UPDATE Tickets
            SET title = @title,
                description = @description,
                solution = @solution,
                priority_id = @priority_id,
                status_id = @status_id
            WHERE ID = @ID;
        ";

        public string GetTicketsByClientId = @"
            SELECT 
                t.ID,
                t.created_at,
                t.updated_at,
                t.title,
                t.description,
                t.solution,
                t.closed_at,
                t.client_id,
                c.first_name AS client_name,
                t.priority_id,
                p.priority_name,
                t.status_id,
                s.status_name,
                t.assigned_to,
                u.first_name AS assigned_user_name
            FROM 
                Tickets t
            LEFT JOIN 
                Users c ON t.client_id = c.ID
            LEFT JOIN 
                Priorities p ON t.priority_id = p.ID
            LEFT JOIN 
                Statuses s ON t.status_id = s.ID
            LEFT JOIN 
                Users u ON t.assigned_to = u.ID
            WHERE t.client_id = @client_id
            ORDER BY t.created_at DESC;
        ";

        public string GetTicketsByClientIdSearch = @"
             SELECT 
                t.ID,
                t.created_at,
                t.updated_at,
                t.title,
                t.description,
                t.solution,
                t.closed_at,
                t.client_id,
                c.first_name AS client_name,
                t.priority_id,
                p.priority_name,
                t.status_id,
                s.status_name,
                t.assigned_to,
                u.first_name AS assigned_user_name
            FROM 
                Tickets t
            LEFT JOIN 
                Users c ON t.client_id = c.ID
            LEFT JOIN 
                Priorities p ON t.priority_id = p.ID
            LEFT JOIN 
                Statuses s ON t.status_id = s.ID
            LEFT JOIN 
                Users u ON t.assigned_to = u.ID
            WHERE 
                t.client_id = @client_id
                AND (
                    t.title ILIKE '%' || @searchTerm || '%'
                    OR t.description ILIKE '%' || @searchTerm || '%'
                )
            ORDER BY t.created_at DESC;
        ";
    
        public string GetTicketByID = @"
             SELECT 
                t.ID,
                t.created_at,
                t.updated_at,
                t.title,
                t.description,
                t.solution,
                t.closed_at,
                t.client_id,
                c.first_name AS client_name,
                t.priority_id,
                p.priority_name,
                t.status_id,
                s.status_name,
                t.assigned_to,
                u.first_name AS assigned_user_name
            FROM 
                Tickets t
            LEFT JOIN 
                Users c ON t.client_id = c.ID
            LEFT JOIN 
                Priorities p ON t.priority_id = p.ID
            LEFT JOIN 
                Statuses s ON t.status_id = s.ID
            LEFT JOIN 
                Users u ON t.assigned_to = u.ID
            WHERE 
                t.ID = @ID
            ORDER BY t.created_at DESC;
        ";

        public string GetNewTickets = @"
            SELECT 
                t.ID,
                t.created_at,
                t.updated_at,
                t.title,
                t.description,
                t.solution,
                t.closed_at,
                t.client_id,
                c.first_name AS client_name,
                t.priority_id,
                p.priority_name,
                t.status_id,
                s.status_name,
                t.assigned_to,
                u.first_name AS assigned_user_name
            FROM 
                Tickets t
            LEFT JOIN 
                Users c ON t.client_id = c.ID
            LEFT JOIN 
                Priorities p ON t.priority_id = p.ID
            LEFT JOIN 
                Statuses s ON t.status_id = s.ID
            LEFT JOIN 
                Users u ON t.assigned_to = u.ID
            WHERE t.status_id = @status_id
            ORDER BY t.created_at DESC;
        ";

        public string GetNewTicketsSearch = @"
             SELECT 
                t.ID,
                t.created_at,
                t.updated_at,
                t.title,
                t.description,
                t.solution,
                t.closed_at,
                t.client_id,
                c.first_name AS client_name,
                t.priority_id,
                p.priority_name,
                t.status_id,
                s.status_name,
                t.assigned_to,
                u.first_name AS assigned_user_name
            FROM 
                Tickets t
            LEFT JOIN 
                Users c ON t.client_id = c.ID
            LEFT JOIN 
                Priorities p ON t.priority_id = p.ID
            LEFT JOIN 
                Statuses s ON t.status_id = s.ID
            LEFT JOIN 
                Users u ON t.assigned_to = u.ID
            WHERE 
                t.status_id = @status_id
                AND (
                    t.title ILIKE '%' || @searchTerm || '%'
                    OR t.description ILIKE '%' || @searchTerm || '%'
                )
            ORDER BY t.created_at DESC;
        ";

        public string GetAssignedTickets = @"
            SELECT 
                t.ID,
                t.created_at,
                t.updated_at,
                t.title,
                t.description,
                t.solution,
                t.closed_at,
                t.client_id,
                c.first_name AS client_name,
                t.priority_id,
                p.priority_name,
                t.status_id,
                s.status_name,
                t.assigned_to,
                u.first_name AS assigned_user_name
            FROM 
                Tickets t
            LEFT JOIN 
                Users c ON t.client_id = c.ID
            LEFT JOIN 
                Priorities p ON t.priority_id = p.ID
            LEFT JOIN 
                Statuses s ON t.status_id = s.ID
            LEFT JOIN 
                Users u ON t.assigned_to = u.ID
            WHERE t.assigned_to = @assigned_to
            ORDER BY t.created_at DESC;
        ";

        public string GetAssignedTicketsSearch = @"
             SELECT 
                t.ID,
                t.created_at,
                t.updated_at,
                t.title,
                t.description,
                t.solution,
                t.closed_at,
                t.client_id,
                c.first_name AS client_name,
                t.priority_id,
                p.priority_name,
                t.status_id,
                s.status_name,
                t.assigned_to,
                u.first_name AS assigned_user_name
            FROM 
                Tickets t
            LEFT JOIN 
                Users c ON t.client_id = c.ID
            LEFT JOIN 
                Priorities p ON t.priority_id = p.ID
            LEFT JOIN 
                Statuses s ON t.status_id = s.ID
            LEFT JOIN 
                Users u ON t.assigned_to = u.ID
            WHERE 
                t.assigned_to = @assigned_to
                AND (
                    t.title ILIKE '%' || @searchTerm || '%'
                    OR t.description ILIKE '%' || @searchTerm || '%'
                )
            ORDER BY t.created_at DESC;
        ";

        public string GetTickets = @"
            SELECT 
                t.ID,
                t.created_at,
                t.updated_at,
                t.title,
                t.description,
                t.solution,
                t.closed_at,
                t.client_id,
                c.first_name AS client_name,
                t.priority_id,
                p.priority_name,
                t.status_id,
                s.status_name,
                t.assigned_to,
                u.first_name AS assigned_user_name
            FROM 
                Tickets t
            LEFT JOIN 
                Users c ON t.client_id = c.ID
            LEFT JOIN 
                Priorities p ON t.priority_id = p.ID
            LEFT JOIN 
                Statuses s ON t.status_id = s.ID
            LEFT JOIN 
                Users u ON t.assigned_to = u.ID
            ORDER BY t.created_at DESC;
        ";

    }
}
